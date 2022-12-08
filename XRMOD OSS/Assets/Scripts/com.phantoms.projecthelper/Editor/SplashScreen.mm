#include "SplashScreen.h"
#include "UnityViewControllerBase.h"
#include "OrientationSupport.h"
#include "Unity/ObjCRuntime.h"
#include "UI/UnityView.h"
#include <cstring>
#include "Unity/UnitySharedDecls.h"

#include <utility>

static SplashScreen*            _splash      = nil;
static SplashScreenController*  _controller  = nil;

@implementation SplashScreen
{
    UIImageView* m_ImageView;
    UIView* m_XibView;
}

- (id)initWithFrame:(CGRect)frame
{
    self = [super initWithFrame: frame];
    return self;
}

- (void)createUI
{
    //ignore in AR-MOD
}

- (void)updateOrientation:(ScreenOrientation)orient withSupportedOrientations:(const OrientationMask&)supportedOrientations
{
    CGFloat scale = UnityScreenScaleFactor([UIScreen mainScreen]);
    UnityReportResizeView(self.bounds.size.width * scale, self.bounds.size.height * scale, orient);
    ReportSafeAreaChangeForView(self);

    // for iOS only xib/storyboard are supported, for tvOS (launch images are supported) no orientation takes place at all
}

- (void)layoutSubviews
{
    if (self->m_XibView)
        self->m_XibView.frame = self.bounds;
    else if (self->m_ImageView)
        self->m_ImageView.frame = self.bounds;
}

+ (SplashScreen*)Instance
{
    return _splash;
}

- (void)freeSubviews
{
    m_ImageView = nil;
    m_XibView = nil;
}

@end

@implementation SplashScreenController
{
    OrientationMask _supportedOrientations;
}

- (id)init
{
    self = [super init];
    if (self)
    {
        self->_supportedOrientations = { false, false, false, false };
    }
    return self;
}

- (void)viewWillTransitionToSize:(CGSize)size withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator>)coordinator
{
    ScreenOrientation curOrient = UIViewControllerOrientation(self);
    ScreenOrientation newOrient = OrientationAfterTransform(curOrient, [coordinator targetTransform]);
    [_splash updateOrientation: newOrient withSupportedOrientations: self->_supportedOrientations];

    [super viewWillTransitionToSize: size withTransitionCoordinator: coordinator];
}

- (void)create:(UIWindow*)window
{
    //ignore in AR-MOD
}

#if PLATFORM_IOS

- (BOOL)shouldAutorotate
{
    return YES;
}

- (NSUInteger)supportedInterfaceOrientations
{
    NSUInteger ret = 0;

    if (self->_supportedOrientations.portrait)
        ret |= (1 << UIInterfaceOrientationPortrait);
    if (self->_supportedOrientations.portraitUpsideDown)
        ret |= (1 << UIInterfaceOrientationPortraitUpsideDown);
    if (self->_supportedOrientations.landscapeLeft)
        ret |= (1 << UIInterfaceOrientationLandscapeRight);
    if (self->_supportedOrientations.landscapeRight)
        ret |= (1 << UIInterfaceOrientationLandscapeLeft);

    return ret;
}

#endif

+ (SplashScreenController*)Instance
{
    return _controller;
}

@end

// on ios13 we can finally tweak initial storyboard view controller: use unity base view controller
// this way we can handle orientations/status-bar/whatever-we-want-to-tweak uniformly
// the only caveat is that we should handle orientations in a special way as unity default view controller expects autorotation
@interface UnityViewControllerStoryboard : UnityViewControllerBase
#if PLATFORM_IOS
- (NSUInteger)supportedInterfaceOrientations;
#endif
@end
@implementation UnityViewControllerStoryboard
#if PLATFORM_IOS
- (NSUInteger)supportedInterfaceOrientations
{
    return EnabledAutorotationInterfaceOrientations();
}

#endif
@end

void ShowSplashScreen(UIWindow* window)
{   
     //...
    //ignore in AR-MOD
    //...
    
    _controller = [[SplashScreenController alloc] init];
    [_controller create: window];
    [window makeKeyAndVisible];
}

void HideSplashScreen()
{
    if (_splash)
    {
        [_splash removeFromSuperview];
        [_splash freeSubviews];
    }

    _splash = nil;
    _controller = nil;
}
