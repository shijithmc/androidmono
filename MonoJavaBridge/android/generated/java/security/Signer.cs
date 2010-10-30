namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Signer_))]
	public abstract partial class Signer : java.security.Identity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Signer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23403;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Signer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.Signer._toString23403) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateKey23404;
		public virtual global::java.security.PrivateKey getPrivateKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PrivateKey>(this, global::java.security.Signer.staticClass, "getPrivateKey", "()Ljava/security/PrivateKey;", ref global::java.security.Signer._getPrivateKey23404) as java.security.PrivateKey;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyPair23405;
		public virtual void setKeyPair(java.security.KeyPair arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signer.staticClass, "setKeyPair", "(Ljava/security/KeyPair;)V", ref global::java.security.Signer._setKeyPair23405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Signer23406;
		public Signer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signer._Signer23406.native == global::System.IntPtr.Zero)
				global::java.security.Signer._Signer23406 = @__env.GetMethodIDNoThrow(global::java.security.Signer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Signer.staticClass, global::java.security.Signer._Signer23406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Signer23407;
		public Signer(java.lang.String arg0, java.security.IdentityScope arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signer._Signer23407.native == global::System.IntPtr.Zero)
				global::java.security.Signer._Signer23407 = @__env.GetMethodIDNoThrow(global::java.security.Signer.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Signer.staticClass, global::java.security.Signer._Signer23407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Signer23408;
		protected Signer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signer._Signer23408.native == global::System.IntPtr.Zero)
				global::java.security.Signer._Signer23408 = @__env.GetMethodIDNoThrow(global::java.security.Signer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Signer.staticClass, global::java.security.Signer._Signer23408);
			Init(@__env, handle);
		}
		static Signer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Signer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Signer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Signer))]
	internal sealed partial class Signer_ : java.security.Signer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Signer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Signer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Signer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Signer"));
		}
		internal static void InitJNI()
		{
		}
	}
}