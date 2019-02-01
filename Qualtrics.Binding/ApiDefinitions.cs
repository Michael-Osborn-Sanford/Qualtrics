using System;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;
using WebKit;

namespace Com.Qualtrics.Digital
{
    // @interface InitializationResult : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    [Protocol] // INTENTIONAL MODIFICATION
    interface InitializationResult
    {
        // -(NSString * _Nullable)getMessage __attribute__((warn_unused_result));
        [NullAllowed, Export("getMessage")]
        //[Verify (MethodToProperty)]
        string Message { get; }

        // -(BOOL)passed __attribute__((warn_unused_result));
        [Export("passed")]
        //[Verify (MethodToProperty)]
        bool Passed { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        InitializationResult New();
    }

    // @interface Properties : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol] // INTENTIONAL MODIFICATION
    interface Properties
    {
        // -(void)setStringWithString:(NSString * _Nonnull)string for:(NSString * _Nonnull)key;
        [Export("setStringWithString:for:")]
        void SetStringWithString(string @string, string key);

        // -(void)setNumberWithNumber:(double)number for:(NSString * _Nonnull)key;
        [Export("setNumberWithNumber:for:")]
        void SetNumberWithNumber(double number, string key);
    }

    // @interface Qualtrics : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    [Protocol] // INTENTIONAL MODIFICATION
    interface Qualtrics
    {
        // @property (readonly, nonatomic, strong, class) Qualtrics * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        Qualtrics Shared { get; }

        // @property (readonly, nonatomic, strong) Properties * _Nonnull properties;
        [Export("properties", ArgumentSemantic.Strong)]
        Properties Properties { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        Qualtrics New();

        // -(void)initializeWithBrandId:(NSString * _Nonnull)brandId zoneId:(NSString * _Nonnull)zoneId interceptId:(NSString * _Nonnull)interceptId completion:(void (^ _Nullable)(InitializationResult * _Nonnull))completion;
        [Export("initializeWithBrandId:zoneId:interceptId:completion:")]
        void InitializeWithBrandId(string brandId, string zoneId, string interceptId, [NullAllowed] Action<InitializationResult> completion);

        // -(void)evaluateTargetingLogicWithCompletion:(void (^ _Nonnull)(TargetingResult * _Nonnull))completion;
        [Export("evaluateTargetingLogicWithCompletion:")]
        void EvaluateTargetingLogicWithCompletion(Action<TargetingResult> completion);

        // -(BOOL)handleLocalNotificationWithResponse:(UNNotificationResponse * _Nonnull)response displayOn:(UIViewController * _Nonnull)viewController __attribute__((availability(ios, introduced=10.0))) __attribute__((warn_unused_result));
#pragma warning disable CS0618 // Type or member is obsolete  INTENTIONAL MODIFICATION
        [iOS(10, 0)]
#pragma warning restore CS0618 // Type or member is obsolete  INTENTIONAL MODIFICATION
        [Export("handleLocalNotificationWithResponse:displayOn:")]
        bool HandleLocalNotificationWithResponse(UNNotificationResponse response, UIViewController viewController);

        // -(BOOL)handleLocalNotification:(UILocalNotification * _Nonnull)notification displayOn:(UIViewController * _Nonnull)viewController __attribute__((warn_unused_result));
        [Export("handleLocalNotification:displayOn:")]
        bool HandleLocalNotification(UILocalNotification notification, UIViewController viewController);

        // -(BOOL)displayWithViewController:(UIViewController * _Nonnull)viewController __attribute__((warn_unused_result));
        [Export("displayWithViewController:")]
        bool DisplayWithViewController(UIViewController viewController);

        // -(void)displayTargetWithTargetViewController:(UIViewController * _Nonnull)targetViewController targetUrl:(NSString * _Nonnull)targetUrl;
        [Export("displayTargetWithTargetViewController:targetUrl:")]
        void DisplayTargetWithTargetViewController(UIViewController targetViewController, string targetUrl);

        // -(BOOL)hide __attribute__((warn_unused_result));
        [Export("hide")]
        //[Verify (MethodToProperty)]
        bool Hide { get; }

        // -(void)registerViewVisitWithViewName:(NSString * _Nonnull)viewName;
        [Export("registerViewVisitWithViewName:")]
        void RegisterViewVisitWithViewName(string viewName);

        // -(void)resetTimer;
        [Export("resetTimer")]
        void ResetTimer();

        // -(void)resetViewCounter;
        [Export("resetViewCounter")]
        void ResetViewCounter();
    }

    // @interface QualtricsSurveyViewController : UIViewController <WKScriptMessageHandler>
    [BaseType(typeof(UIViewController))]
    [Protocol] // INTENTIONAL MODIFICATION
    interface QualtricsSurveyViewController : IWKScriptMessageHandler
    {
        // -(instancetype _Nonnull)initWithUrl:(NSString * _Nonnull)url __attribute__((objc_designated_initializer));
        [Export("initWithUrl:")]
        [DesignatedInitializer]
        IntPtr Constructor(string url);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export ("initWithCoder:")] INTENTIONAL MODIFICATION
        //[DesignatedInitializer] INTENTIONAL MODIFICATION
        //IntPtr Constructor(NSCoder aDecoder);

        // -(void)viewDidAppear:(BOOL)animated;
        [Export("viewDidAppear:")]
        void ViewDidAppear(bool animated);

        // -(void)userContentController:(WKUserContentController * _Nonnull)userContentController didReceiveScriptMessage:(WKScriptMessage * _Nonnull)message;
        //[Export ("userContentController:didReceiveScriptMessage:")] INTENTIONAL MODIFICATION
        //void UserContentController (WKUserContentController userContentController, WKScriptMessage message); INTENTIONAL MODIFICATION
    }

    // @interface TargetingResult : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    [Protocol] // INTENTIONAL MODIFICATION
    interface TargetingResult
    {
        // -(NSString * _Nullable)getSurveyUrl __attribute__((warn_unused_result));
        [NullAllowed, Export("getSurveyUrl")]
        //[Verify (MethodToProperty)]
        string SurveyUrl { get; }

        // -(BOOL)passed __attribute__((warn_unused_result));
        [Export("passed")]
        //[Verify (MethodToProperty)]
        bool Passed { get; }

        // -(void)recordImpression;
        [Export("recordImpression")]
        void RecordImpression();

        // -(void)recordClick;
        [Export("recordClick")]
        void RecordClick();

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        TargetingResult New();
    }

    // @interface Qualtrics_Swift_254 (UIColor)
    [Category]
    [BaseType(typeof(UIColor))]
    interface UIColor_Qualtrics_Swift_254
    {
        // -(instancetype _Nullable)initWithHexString:(NSString * _Nonnull)hexString;
        //[Export ("initWithHexString:")] INTENTIONAL MODIFICATION
        //IntPtr Constructor (string hexString); INTENTIONAL MODIFICATION
    }
}
