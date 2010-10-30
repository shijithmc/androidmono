namespace android.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.LoginFilter_))]
	public abstract partial class LoginFilter : java.lang.Object, InputFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LoginFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class PasswordFilterGMail : android.text.LoginFilter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PasswordFilterGMail(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _isAllowed12887;
			public override bool isAllowed(char arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.LoginFilter.PasswordFilterGMail.staticClass, "isAllowed", "(C)Z", ref global::android.text.LoginFilter.PasswordFilterGMail._isAllowed12887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _PasswordFilterGMail12888;
			public PasswordFilterGMail() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.LoginFilter.PasswordFilterGMail._PasswordFilterGMail12888.native == global::System.IntPtr.Zero)
					global::android.text.LoginFilter.PasswordFilterGMail._PasswordFilterGMail12888 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.PasswordFilterGMail.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.LoginFilter.PasswordFilterGMail.staticClass, global::android.text.LoginFilter.PasswordFilterGMail._PasswordFilterGMail12888);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _PasswordFilterGMail12889;
			public PasswordFilterGMail(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.LoginFilter.PasswordFilterGMail._PasswordFilterGMail12889.native == global::System.IntPtr.Zero)
					global::android.text.LoginFilter.PasswordFilterGMail._PasswordFilterGMail12889 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.PasswordFilterGMail.staticClass, "<init>", "(Z)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.LoginFilter.PasswordFilterGMail.staticClass, global::android.text.LoginFilter.PasswordFilterGMail._PasswordFilterGMail12889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static PasswordFilterGMail()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.LoginFilter.PasswordFilterGMail.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/LoginFilter$PasswordFilterGMail"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class UsernameFilterGMail : android.text.LoginFilter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected UsernameFilterGMail(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _isAllowed12890;
			public override bool isAllowed(char arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.LoginFilter.UsernameFilterGMail.staticClass, "isAllowed", "(C)Z", ref global::android.text.LoginFilter.UsernameFilterGMail._isAllowed12890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _UsernameFilterGMail12891;
			public UsernameFilterGMail() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.LoginFilter.UsernameFilterGMail._UsernameFilterGMail12891.native == global::System.IntPtr.Zero)
					global::android.text.LoginFilter.UsernameFilterGMail._UsernameFilterGMail12891 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.UsernameFilterGMail.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.LoginFilter.UsernameFilterGMail.staticClass, global::android.text.LoginFilter.UsernameFilterGMail._UsernameFilterGMail12891);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _UsernameFilterGMail12892;
			public UsernameFilterGMail(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.LoginFilter.UsernameFilterGMail._UsernameFilterGMail12892.native == global::System.IntPtr.Zero)
					global::android.text.LoginFilter.UsernameFilterGMail._UsernameFilterGMail12892 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.UsernameFilterGMail.staticClass, "<init>", "(Z)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.LoginFilter.UsernameFilterGMail.staticClass, global::android.text.LoginFilter.UsernameFilterGMail._UsernameFilterGMail12892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static UsernameFilterGMail()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.LoginFilter.UsernameFilterGMail.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/LoginFilter$UsernameFilterGMail"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class UsernameFilterGeneric : android.text.LoginFilter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected UsernameFilterGeneric(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _isAllowed12893;
			public override bool isAllowed(char arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.LoginFilter.UsernameFilterGeneric.staticClass, "isAllowed", "(C)Z", ref global::android.text.LoginFilter.UsernameFilterGeneric._isAllowed12893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _UsernameFilterGeneric12894;
			public UsernameFilterGeneric() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.LoginFilter.UsernameFilterGeneric._UsernameFilterGeneric12894.native == global::System.IntPtr.Zero)
					global::android.text.LoginFilter.UsernameFilterGeneric._UsernameFilterGeneric12894 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.UsernameFilterGeneric.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.LoginFilter.UsernameFilterGeneric.staticClass, global::android.text.LoginFilter.UsernameFilterGeneric._UsernameFilterGeneric12894);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _UsernameFilterGeneric12895;
			public UsernameFilterGeneric(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.LoginFilter.UsernameFilterGeneric._UsernameFilterGeneric12895.native == global::System.IntPtr.Zero)
					global::android.text.LoginFilter.UsernameFilterGeneric._UsernameFilterGeneric12895 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.UsernameFilterGeneric.staticClass, "<init>", "(Z)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.LoginFilter.UsernameFilterGeneric.staticClass, global::android.text.LoginFilter.UsernameFilterGeneric._UsernameFilterGeneric12895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static UsernameFilterGeneric()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.LoginFilter.UsernameFilterGeneric.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/LoginFilter$UsernameFilterGeneric"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _filter12896;
		public virtual global::java.lang.CharSequence filter(java.lang.CharSequence arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.LoginFilter.staticClass, "filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", ref global::android.text.LoginFilter._filter12896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as java.lang.CharSequence;
		}
		public java.lang.CharSequence filter(string arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			return filter((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::MonoJavaBridge.MethodId _onStart12897;
		public virtual void onStart()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.LoginFilter.staticClass, "onStart", "()V", ref global::android.text.LoginFilter._onStart12897);
		}
		internal static global::MonoJavaBridge.MethodId _onStop12898;
		public virtual void onStop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.LoginFilter.staticClass, "onStop", "()V", ref global::android.text.LoginFilter._onStop12898);
		}
		internal static global::MonoJavaBridge.MethodId _isAllowed12899;
		public abstract bool isAllowed(char arg0);
		internal static global::MonoJavaBridge.MethodId _onInvalidCharacter12900;
		public virtual void onInvalidCharacter(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.LoginFilter.staticClass, "onInvalidCharacter", "(C)V", ref global::android.text.LoginFilter._onInvalidCharacter12900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static LoginFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.LoginFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/LoginFilter"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.LoginFilter))]
	internal sealed partial class LoginFilter_ : android.text.LoginFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LoginFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isAllowed12901;
		public override bool isAllowed(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.LoginFilter_.staticClass, "isAllowed", "(C)Z", ref global::android.text.LoginFilter_._isAllowed12901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static LoginFilter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.LoginFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/LoginFilter"));
		}
		internal static void InitJNI()
		{
		}
	}
}