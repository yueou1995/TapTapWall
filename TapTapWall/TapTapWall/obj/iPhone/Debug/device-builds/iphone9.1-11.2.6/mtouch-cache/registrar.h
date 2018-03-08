#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#define DEBUG 1
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <CloudKit/CloudKit.h>
#import <QuartzCore/QuartzCore.h>
#import <Intents/Intents.h>

@class UIKit_UIControlEventProxy;
@class __MonoMac_NSActionDispatcher;
@class __MonoMac_NSAsyncActionDispatcher;
@class AppDelegate;
@class ViewController;
@class TapTapWall_BattleCell;
@class __NSObject_Disposer;

@interface AppDelegate : NSObject<UIApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(void) applicationWillResignActive:(UIApplication *)p0;
	-(void) applicationDidEnterBackground:(UIApplication *)p0;
	-(void) applicationWillEnterForeground:(UIApplication *)p0;
	-(void) applicationDidBecomeActive:(UIApplication *)p0;
	-(void) applicationWillTerminate:(UIApplication *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface ViewController : UIViewController {
}
	@property (nonatomic, assign) UIImageView * BottomGameOverImage;
	@property (nonatomic, assign) UIButton * Button_B0;
	@property (nonatomic, assign) UIButton * Button_B1;
	@property (nonatomic, assign) UIButton * Button_B10;
	@property (nonatomic, assign) UIButton * Button_B11;
	@property (nonatomic, assign) UIButton * Button_B12;
	@property (nonatomic, assign) UIButton * Button_B13;
	@property (nonatomic, assign) UIButton * Button_B14;
	@property (nonatomic, assign) UIButton * Button_B15;
	@property (nonatomic, assign) UIButton * Button_B16;
	@property (nonatomic, assign) UIButton * Button_B17;
	@property (nonatomic, assign) UIButton * Button_B18;
	@property (nonatomic, assign) UIButton * Button_B19;
	@property (nonatomic, assign) UIButton * Button_B2;
	@property (nonatomic, assign) UIButton * Button_B20;
	@property (nonatomic, assign) UIButton * Button_B21;
	@property (nonatomic, assign) UIButton * Button_B22;
	@property (nonatomic, assign) UIButton * Button_B23;
	@property (nonatomic, assign) UIButton * Button_B3;
	@property (nonatomic, assign) UIButton * Button_B4;
	@property (nonatomic, assign) UIButton * Button_B5;
	@property (nonatomic, assign) UIButton * Button_B6;
	@property (nonatomic, assign) UIButton * Button_B7;
	@property (nonatomic, assign) UIButton * Button_B8;
	@property (nonatomic, assign) UIButton * Button_B9;
	@property (nonatomic, assign) UIButton * Button_T0;
	@property (nonatomic, assign) UIButton * Button_T1;
	@property (nonatomic, assign) UIButton * Button_T10;
	@property (nonatomic, assign) UIButton * Button_T11;
	@property (nonatomic, assign) UIButton * Button_T12;
	@property (nonatomic, assign) UIButton * Button_T13;
	@property (nonatomic, assign) UIButton * Button_T14;
	@property (nonatomic, assign) UIButton * Button_T15;
	@property (nonatomic, assign) UIButton * Button_T16;
	@property (nonatomic, assign) UIButton * Button_T17;
	@property (nonatomic, assign) UIButton * Button_T18;
	@property (nonatomic, assign) UIButton * Button_T19;
	@property (nonatomic, assign) UIButton * Button_T2;
	@property (nonatomic, assign) UIButton * Button_T20;
	@property (nonatomic, assign) UIButton * Button_T21;
	@property (nonatomic, assign) UIButton * Button_T22;
	@property (nonatomic, assign) UIButton * Button_T23;
	@property (nonatomic, assign) UIButton * Button_T3;
	@property (nonatomic, assign) UIButton * Button_T4;
	@property (nonatomic, assign) UIButton * Button_T5;
	@property (nonatomic, assign) UIButton * Button_T6;
	@property (nonatomic, assign) UIButton * Button_T7;
	@property (nonatomic, assign) UIButton * Button_T8;
	@property (nonatomic, assign) UIButton * Button_T9;
	@property (nonatomic, assign) UILabel * TitleLabel;
	@property (nonatomic, assign) UIImageView * TopGameOverImage;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIImageView *) BottomGameOverImage;
	-(void) setBottomGameOverImage:(UIImageView *)p0;
	-(UIButton *) Button_B0;
	-(void) setButton_B0:(UIButton *)p0;
	-(UIButton *) Button_B1;
	-(void) setButton_B1:(UIButton *)p0;
	-(UIButton *) Button_B10;
	-(void) setButton_B10:(UIButton *)p0;
	-(UIButton *) Button_B11;
	-(void) setButton_B11:(UIButton *)p0;
	-(UIButton *) Button_B12;
	-(void) setButton_B12:(UIButton *)p0;
	-(UIButton *) Button_B13;
	-(void) setButton_B13:(UIButton *)p0;
	-(UIButton *) Button_B14;
	-(void) setButton_B14:(UIButton *)p0;
	-(UIButton *) Button_B15;
	-(void) setButton_B15:(UIButton *)p0;
	-(UIButton *) Button_B16;
	-(void) setButton_B16:(UIButton *)p0;
	-(UIButton *) Button_B17;
	-(void) setButton_B17:(UIButton *)p0;
	-(UIButton *) Button_B18;
	-(void) setButton_B18:(UIButton *)p0;
	-(UIButton *) Button_B19;
	-(void) setButton_B19:(UIButton *)p0;
	-(UIButton *) Button_B2;
	-(void) setButton_B2:(UIButton *)p0;
	-(UIButton *) Button_B20;
	-(void) setButton_B20:(UIButton *)p0;
	-(UIButton *) Button_B21;
	-(void) setButton_B21:(UIButton *)p0;
	-(UIButton *) Button_B22;
	-(void) setButton_B22:(UIButton *)p0;
	-(UIButton *) Button_B23;
	-(void) setButton_B23:(UIButton *)p0;
	-(UIButton *) Button_B3;
	-(void) setButton_B3:(UIButton *)p0;
	-(UIButton *) Button_B4;
	-(void) setButton_B4:(UIButton *)p0;
	-(UIButton *) Button_B5;
	-(void) setButton_B5:(UIButton *)p0;
	-(UIButton *) Button_B6;
	-(void) setButton_B6:(UIButton *)p0;
	-(UIButton *) Button_B7;
	-(void) setButton_B7:(UIButton *)p0;
	-(UIButton *) Button_B8;
	-(void) setButton_B8:(UIButton *)p0;
	-(UIButton *) Button_B9;
	-(void) setButton_B9:(UIButton *)p0;
	-(UIButton *) Button_T0;
	-(void) setButton_T0:(UIButton *)p0;
	-(UIButton *) Button_T1;
	-(void) setButton_T1:(UIButton *)p0;
	-(UIButton *) Button_T10;
	-(void) setButton_T10:(UIButton *)p0;
	-(UIButton *) Button_T11;
	-(void) setButton_T11:(UIButton *)p0;
	-(UIButton *) Button_T12;
	-(void) setButton_T12:(UIButton *)p0;
	-(UIButton *) Button_T13;
	-(void) setButton_T13:(UIButton *)p0;
	-(UIButton *) Button_T14;
	-(void) setButton_T14:(UIButton *)p0;
	-(UIButton *) Button_T15;
	-(void) setButton_T15:(UIButton *)p0;
	-(UIButton *) Button_T16;
	-(void) setButton_T16:(UIButton *)p0;
	-(UIButton *) Button_T17;
	-(void) setButton_T17:(UIButton *)p0;
	-(UIButton *) Button_T18;
	-(void) setButton_T18:(UIButton *)p0;
	-(UIButton *) Button_T19;
	-(void) setButton_T19:(UIButton *)p0;
	-(UIButton *) Button_T2;
	-(void) setButton_T2:(UIButton *)p0;
	-(UIButton *) Button_T20;
	-(void) setButton_T20:(UIButton *)p0;
	-(UIButton *) Button_T21;
	-(void) setButton_T21:(UIButton *)p0;
	-(UIButton *) Button_T22;
	-(void) setButton_T22:(UIButton *)p0;
	-(UIButton *) Button_T23;
	-(void) setButton_T23:(UIButton *)p0;
	-(UIButton *) Button_T3;
	-(void) setButton_T3:(UIButton *)p0;
	-(UIButton *) Button_T4;
	-(void) setButton_T4:(UIButton *)p0;
	-(UIButton *) Button_T5;
	-(void) setButton_T5:(UIButton *)p0;
	-(UIButton *) Button_T6;
	-(void) setButton_T6:(UIButton *)p0;
	-(UIButton *) Button_T7;
	-(void) setButton_T7:(UIButton *)p0;
	-(UIButton *) Button_T8;
	-(void) setButton_T8:(UIButton *)p0;
	-(UIButton *) Button_T9;
	-(void) setButton_T9:(UIButton *)p0;
	-(UILabel *) TitleLabel;
	-(void) setTitleLabel:(UILabel *)p0;
	-(UIImageView *) TopGameOverImage;
	-(void) setTopGameOverImage:(UIImageView *)p0;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(void) Button_B0_TouchUpInside:(UIButton *)p0;
	-(void) Button_B1_TouchUpInside:(UIButton *)p0;
	-(void) Button_B10_TouchUpInside:(UIButton *)p0;
	-(void) Button_B11_TouchUpInside:(UIButton *)p0;
	-(void) Button_B12_TouchUpInside:(UIButton *)p0;
	-(void) Button_B13_TouchUpInside:(UIButton *)p0;
	-(void) Button_B14_TouchUpInside:(UIButton *)p0;
	-(void) Button_B15_TouchUpInside:(UIButton *)p0;
	-(void) Button_B16_TouchUpInside:(UIButton *)p0;
	-(void) Button_B17_TouchUpInside:(UIButton *)p0;
	-(void) Button_B18_TouchUpInside:(UIButton *)p0;
	-(void) Button_B19_TouchUpInside:(UIButton *)p0;
	-(void) Button_B2_TouchUpInside:(UIButton *)p0;
	-(void) Button_B20_TouchUpInside:(UIButton *)p0;
	-(void) Button_B21_TouchUpInside:(UIButton *)p0;
	-(void) Button_B22_TouchUpInside:(UIButton *)p0;
	-(void) Button_B23_TouchUpInside:(UIButton *)p0;
	-(void) Button_B3_TouchUpInside:(UIButton *)p0;
	-(void) Button_B4_TouchUpInside:(UIButton *)p0;
	-(void) Button_B5_TouchUpInside:(UIButton *)p0;
	-(void) Button_B6_TouchUpInside:(UIButton *)p0;
	-(void) Button_B7_TouchUpInside:(UIButton *)p0;
	-(void) Button_B8_TouchUpInside:(UIButton *)p0;
	-(void) Button_B9_TouchUpInside:(UIButton *)p0;
	-(void) Button_T0_TouchUpInside:(UIButton *)p0;
	-(void) Button_T1_TouchUpInside:(UIButton *)p0;
	-(void) Button_T10_TouchUpInside:(UIButton *)p0;
	-(void) Button_T11_TouchUpInside:(UIButton *)p0;
	-(void) Button_T12_TouchUpInside:(UIButton *)p0;
	-(void) Button_T13_TouchUpInside:(UIButton *)p0;
	-(void) Button_T14_TouchUpInside:(UIButton *)p0;
	-(void) Button_T15_TouchUpInside:(UIButton *)p0;
	-(void) Button_T16_TouchUpInside:(UIButton *)p0;
	-(void) Button_T17_TouchUpInside:(UIButton *)p0;
	-(void) Button_T18_TouchUpInside:(UIButton *)p0;
	-(void) Button_T19_TouchUpInside:(UIButton *)p0;
	-(void) Button_T2_TouchUpInside:(UIButton *)p0;
	-(void) Button_T20_TouchUpInside:(UIButton *)p0;
	-(void) Button_T21_TouchUpInside:(UIButton *)p0;
	-(void) Button_T22_TouchUpInside:(UIButton *)p0;
	-(void) Button_T23_TouchUpInside:(UIButton *)p0;
	-(void) Button_T3_TouchUpInside:(UIButton *)p0;
	-(void) Button_T4_TouchUpInside:(UIButton *)p0;
	-(void) Button_T5_TouchUpInside:(UIButton *)p0;
	-(void) Button_T6_TouchUpInside:(UIButton *)p0;
	-(void) Button_T7_TouchUpInside:(UIButton *)p0;
	-(void) Button_T8_TouchUpInside:(UIButton *)p0;
	-(void) Button_T9_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface TapTapWall_BattleCell : UIButton {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end


