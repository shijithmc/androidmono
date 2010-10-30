namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WindowManager_LayoutParams : android.view.ViewGroup.LayoutParams, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WindowManager_LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString15383;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.WindowManager_LayoutParams.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.WindowManager_LayoutParams._toString15383) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _debug15384;
		public virtual global::java.lang.String debug(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.WindowManager_LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.view.WindowManager_LayoutParams._debug15384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel15385;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.WindowManager_LayoutParams.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.WindowManager_LayoutParams._writeToParcel15385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents15386;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.WindowManager_LayoutParams.staticClass, "describeContents", "()I", ref global::android.view.WindowManager_LayoutParams._describeContents15386);
		}
		internal static global::MonoJavaBridge.MethodId _setTitle15387;
		public virtual void setTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.WindowManager_LayoutParams.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V", ref global::android.view.WindowManager_LayoutParams._setTitle15387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new string Title
		{
			get
			{
				return getTitle().toString();
			}
			set
			{
				setTitle((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTitle15388;
		public virtual global::java.lang.CharSequence getTitle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.WindowManager_LayoutParams.staticClass, "getTitle", "()Ljava/lang/CharSequence;", ref global::android.view.WindowManager_LayoutParams._getTitle15388) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _mayUseInputMethod15389;
		public static bool mayUseInputMethod(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.WindowManager_LayoutParams._mayUseInputMethod15389.native == global::System.IntPtr.Zero)
				global::android.view.WindowManager_LayoutParams._mayUseInputMethod15389 = @__env.GetStaticMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "mayUseInputMethod", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._mayUseInputMethod15389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyFrom15390;
		public virtual int copyFrom(android.view.WindowManager_LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.WindowManager_LayoutParams.staticClass, "copyFrom", "(Landroid/view/WindowManager$LayoutParams;)I", ref global::android.view.WindowManager_LayoutParams._copyFrom15390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams15391;
		public WindowManager_LayoutParams(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15391.native == global::System.IntPtr.Zero)
				global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15391 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams15392;
		public WindowManager_LayoutParams(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15392.native == global::System.IntPtr.Zero)
				global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15392 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams15393;
		public WindowManager_LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15393.native == global::System.IntPtr.Zero)
				global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15393 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams15394;
		public WindowManager_LayoutParams() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15394.native == global::System.IntPtr.Zero)
				global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15394 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15394);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams15395;
		public WindowManager_LayoutParams(int arg0, int arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15395.native == global::System.IntPtr.Zero)
				global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15395 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(IIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams15396;
		public WindowManager_LayoutParams(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15396.native == global::System.IntPtr.Zero)
				global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15396 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(IIIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams15397;
		public WindowManager_LayoutParams(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15397.native == global::System.IntPtr.Zero)
				global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15397 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams15397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x15398;
		public int x
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _x15398);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _y15399;
		public int y
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _y15399);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _horizontalWeight15400;
		public float horizontalWeight
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _horizontalWeight15400);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _verticalWeight15401;
		public float verticalWeight
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _verticalWeight15401);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _type15402;
		public int type
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _type15402);
			}
			set
			{
			}
		}
		public static int FIRST_APPLICATION_WINDOW
		{
			get
			{
				return 1;
			}
		}
		public static int TYPE_BASE_APPLICATION
		{
			get
			{
				return 1;
			}
		}
		public static int TYPE_APPLICATION
		{
			get
			{
				return 2;
			}
		}
		public static int TYPE_APPLICATION_STARTING
		{
			get
			{
				return 3;
			}
		}
		public static int LAST_APPLICATION_WINDOW
		{
			get
			{
				return 99;
			}
		}
		public static int FIRST_SUB_WINDOW
		{
			get
			{
				return 1000;
			}
		}
		public static int TYPE_APPLICATION_PANEL
		{
			get
			{
				return 1000;
			}
		}
		public static int TYPE_APPLICATION_MEDIA
		{
			get
			{
				return 1001;
			}
		}
		public static int TYPE_APPLICATION_SUB_PANEL
		{
			get
			{
				return 1002;
			}
		}
		public static int TYPE_APPLICATION_ATTACHED_DIALOG
		{
			get
			{
				return 1003;
			}
		}
		public static int LAST_SUB_WINDOW
		{
			get
			{
				return 1999;
			}
		}
		public static int FIRST_SYSTEM_WINDOW
		{
			get
			{
				return 2000;
			}
		}
		public static int TYPE_STATUS_BAR
		{
			get
			{
				return 2000;
			}
		}
		public static int TYPE_SEARCH_BAR
		{
			get
			{
				return 2001;
			}
		}
		public static int TYPE_PHONE
		{
			get
			{
				return 2002;
			}
		}
		public static int TYPE_SYSTEM_ALERT
		{
			get
			{
				return 2003;
			}
		}
		public static int TYPE_KEYGUARD
		{
			get
			{
				return 2004;
			}
		}
		public static int TYPE_TOAST
		{
			get
			{
				return 2005;
			}
		}
		public static int TYPE_SYSTEM_OVERLAY
		{
			get
			{
				return 2006;
			}
		}
		public static int TYPE_PRIORITY_PHONE
		{
			get
			{
				return 2007;
			}
		}
		public static int TYPE_SYSTEM_DIALOG
		{
			get
			{
				return 2008;
			}
		}
		public static int TYPE_KEYGUARD_DIALOG
		{
			get
			{
				return 2009;
			}
		}
		public static int TYPE_SYSTEM_ERROR
		{
			get
			{
				return 2010;
			}
		}
		public static int TYPE_INPUT_METHOD
		{
			get
			{
				return 2011;
			}
		}
		public static int TYPE_INPUT_METHOD_DIALOG
		{
			get
			{
				return 2012;
			}
		}
		public static int TYPE_WALLPAPER
		{
			get
			{
				return 2013;
			}
		}
		public static int TYPE_STATUS_BAR_PANEL
		{
			get
			{
				return 2014;
			}
		}
		public static int LAST_SYSTEM_WINDOW
		{
			get
			{
				return 2999;
			}
		}
		internal static global::MonoJavaBridge.FieldId _memoryType15431;
		public int memoryType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _memoryType15431);
			}
			set
			{
			}
		}
		public static int MEMORY_TYPE_NORMAL
		{
			get
			{
				return 0;
			}
		}
		public static int MEMORY_TYPE_HARDWARE
		{
			get
			{
				return 1;
			}
		}
		public static int MEMORY_TYPE_GPU
		{
			get
			{
				return 2;
			}
		}
		public static int MEMORY_TYPE_PUSH_BUFFERS
		{
			get
			{
				return 3;
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags15436;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags15436);
			}
			set
			{
			}
		}
		public static int FLAG_ALLOW_LOCK_WHILE_SCREEN_ON
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_DIM_BEHIND
		{
			get
			{
				return 2;
			}
		}
		public static int FLAG_BLUR_BEHIND
		{
			get
			{
				return 4;
			}
		}
		public static int FLAG_NOT_FOCUSABLE
		{
			get
			{
				return 8;
			}
		}
		public static int FLAG_NOT_TOUCHABLE
		{
			get
			{
				return 16;
			}
		}
		public static int FLAG_NOT_TOUCH_MODAL
		{
			get
			{
				return 32;
			}
		}
		public static int FLAG_TOUCHABLE_WHEN_WAKING
		{
			get
			{
				return 64;
			}
		}
		public static int FLAG_KEEP_SCREEN_ON
		{
			get
			{
				return 128;
			}
		}
		public static int FLAG_LAYOUT_IN_SCREEN
		{
			get
			{
				return 256;
			}
		}
		public static int FLAG_LAYOUT_NO_LIMITS
		{
			get
			{
				return 512;
			}
		}
		public static int FLAG_FULLSCREEN
		{
			get
			{
				return 1024;
			}
		}
		public static int FLAG_FORCE_NOT_FULLSCREEN
		{
			get
			{
				return 2048;
			}
		}
		public static int FLAG_DITHER
		{
			get
			{
				return 4096;
			}
		}
		public static int FLAG_SECURE
		{
			get
			{
				return 8192;
			}
		}
		public static int FLAG_SCALED
		{
			get
			{
				return 16384;
			}
		}
		public static int FLAG_IGNORE_CHEEK_PRESSES
		{
			get
			{
				return 32768;
			}
		}
		public static int FLAG_LAYOUT_INSET_DECOR
		{
			get
			{
				return 65536;
			}
		}
		public static int FLAG_ALT_FOCUSABLE_IM
		{
			get
			{
				return 131072;
			}
		}
		public static int FLAG_WATCH_OUTSIDE_TOUCH
		{
			get
			{
				return 262144;
			}
		}
		public static int FLAG_SHOW_WHEN_LOCKED
		{
			get
			{
				return 524288;
			}
		}
		public static int FLAG_SHOW_WALLPAPER
		{
			get
			{
				return 1048576;
			}
		}
		public static int FLAG_TURN_SCREEN_ON
		{
			get
			{
				return 2097152;
			}
		}
		public static int FLAG_DISMISS_KEYGUARD
		{
			get
			{
				return 4194304;
			}
		}
		public static int SOFT_INPUT_MASK_STATE
		{
			get
			{
				return 15;
			}
		}
		public static int SOFT_INPUT_STATE_UNSPECIFIED
		{
			get
			{
				return 0;
			}
		}
		public static int SOFT_INPUT_STATE_UNCHANGED
		{
			get
			{
				return 1;
			}
		}
		public static int SOFT_INPUT_STATE_HIDDEN
		{
			get
			{
				return 2;
			}
		}
		public static int SOFT_INPUT_STATE_ALWAYS_HIDDEN
		{
			get
			{
				return 3;
			}
		}
		public static int SOFT_INPUT_STATE_VISIBLE
		{
			get
			{
				return 4;
			}
		}
		public static int SOFT_INPUT_STATE_ALWAYS_VISIBLE
		{
			get
			{
				return 5;
			}
		}
		public static int SOFT_INPUT_MASK_ADJUST
		{
			get
			{
				return 240;
			}
		}
		public static int SOFT_INPUT_ADJUST_UNSPECIFIED
		{
			get
			{
				return 0;
			}
		}
		public static int SOFT_INPUT_ADJUST_RESIZE
		{
			get
			{
				return 16;
			}
		}
		public static int SOFT_INPUT_ADJUST_PAN
		{
			get
			{
				return 32;
			}
		}
		public static int SOFT_INPUT_IS_FORWARD_NAVIGATION
		{
			get
			{
				return 256;
			}
		}
		public static float BRIGHTNESS_OVERRIDE_NONE
		{
			get
			{
				return -1.0f;
			}
		}
		public static float BRIGHTNESS_OVERRIDE_OFF
		{
			get
			{
				return 0.0f;
			}
		}
		public static float BRIGHTNESS_OVERRIDE_FULL
		{
			get
			{
				return 1.0f;
			}
		}
		internal static global::MonoJavaBridge.FieldId _softInputMode15475;
		public int softInputMode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _softInputMode15475);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _gravity15476;
		public int gravity
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _gravity15476);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _horizontalMargin15477;
		public float horizontalMargin
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _horizontalMargin15477);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _verticalMargin15478;
		public float verticalMargin
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _verticalMargin15478);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _format15479;
		public int format
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _format15479);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _windowAnimations15480;
		public int windowAnimations
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _windowAnimations15480);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _alpha15481;
		public float alpha
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _alpha15481);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dimAmount15482;
		public float dimAmount
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _dimAmount15482);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _screenBrightness15483;
		public float screenBrightness
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _screenBrightness15483);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _buttonBrightness15484;
		public float buttonBrightness
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _buttonBrightness15484);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _token15485;
		public global::android.os.IBinder token
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.GetObjectField(this.JvmHandle, _token15485)) as android.os.IBinder;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName15486;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName15486)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _screenOrientation15487;
		public int screenOrientation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _screenOrientation15487);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR15488;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.WindowManager_LayoutParams.staticClass, _CREATOR15488)) as android.os.Parcelable_Creator;
			}
		}
		public static int LAYOUT_CHANGED
		{
			get
			{
				return 1;
			}
		}
		public static int TYPE_CHANGED
		{
			get
			{
				return 2;
			}
		}
		public static int FLAGS_CHANGED
		{
			get
			{
				return 4;
			}
		}
		public static int FORMAT_CHANGED
		{
			get
			{
				return 8;
			}
		}
		public static int ANIMATION_CHANGED
		{
			get
			{
				return 16;
			}
		}
		public static int DIM_AMOUNT_CHANGED
		{
			get
			{
				return 32;
			}
		}
		public static int TITLE_CHANGED
		{
			get
			{
				return 64;
			}
		}
		public static int ALPHA_CHANGED
		{
			get
			{
				return 128;
			}
		}
		public static int MEMORY_TYPE_CHANGED
		{
			get
			{
				return 256;
			}
		}
		public static int SOFT_INPUT_MODE_CHANGED
		{
			get
			{
				return 512;
			}
		}
		public static int SCREEN_ORIENTATION_CHANGED
		{
			get
			{
				return 1024;
			}
		}
		public static int SCREEN_BRIGHTNESS_CHANGED
		{
			get
			{
				return 2048;
			}
		}
		static WindowManager_LayoutParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.WindowManager_LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/WindowManager$LayoutParams"));
			global::android.view.WindowManager_LayoutParams._x15398 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "x", "I");
			global::android.view.WindowManager_LayoutParams._y15399 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "y", "I");
			global::android.view.WindowManager_LayoutParams._horizontalWeight15400 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "horizontalWeight", "F");
			global::android.view.WindowManager_LayoutParams._verticalWeight15401 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "verticalWeight", "F");
			global::android.view.WindowManager_LayoutParams._type15402 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "type", "I");
			global::android.view.WindowManager_LayoutParams._memoryType15431 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "memoryType", "I");
			global::android.view.WindowManager_LayoutParams._flags15436 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "flags", "I");
			global::android.view.WindowManager_LayoutParams._softInputMode15475 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "softInputMode", "I");
			global::android.view.WindowManager_LayoutParams._gravity15476 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "gravity", "I");
			global::android.view.WindowManager_LayoutParams._horizontalMargin15477 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "horizontalMargin", "F");
			global::android.view.WindowManager_LayoutParams._verticalMargin15478 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "verticalMargin", "F");
			global::android.view.WindowManager_LayoutParams._format15479 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "format", "I");
			global::android.view.WindowManager_LayoutParams._windowAnimations15480 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "windowAnimations", "I");
			global::android.view.WindowManager_LayoutParams._alpha15481 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "alpha", "F");
			global::android.view.WindowManager_LayoutParams._dimAmount15482 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "dimAmount", "F");
			global::android.view.WindowManager_LayoutParams._screenBrightness15483 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "screenBrightness", "F");
			global::android.view.WindowManager_LayoutParams._buttonBrightness15484 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "buttonBrightness", "F");
			global::android.view.WindowManager_LayoutParams._token15485 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "token", "Landroid/os/IBinder;");
			global::android.view.WindowManager_LayoutParams._packageName15486 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "packageName", "Ljava/lang/String;");
			global::android.view.WindowManager_LayoutParams._screenOrientation15487 = @__env.GetFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "screenOrientation", "I");
			global::android.view.WindowManager_LayoutParams._CREATOR15488 = @__env.GetStaticFieldIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}