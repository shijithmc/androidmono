namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SecretKeySpec : java.lang.Object, java.security.spec.KeySpec, SecretKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecretKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals28824;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.crypto.spec.SecretKeySpec.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::javax.crypto.spec.SecretKeySpec._equals28824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode28825;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.SecretKeySpec.staticClass, "hashCode", "()I", ref global::javax.crypto.spec.SecretKeySpec._hashCode28825);
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded28826;
		public virtual byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.spec.SecretKeySpec.staticClass, "getEncoded", "()[B", ref global::javax.crypto.spec.SecretKeySpec._getEncoded28826) as byte[];
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28827;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.spec.SecretKeySpec.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.spec.SecretKeySpec._getAlgorithm28827) as java.lang.String;
		}
		public new global::java.lang.String Format
		{
			get
			{
				return getFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormat28828;
		public virtual global::java.lang.String getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.spec.SecretKeySpec.staticClass, "getFormat", "()Ljava/lang/String;", ref global::javax.crypto.spec.SecretKeySpec._getFormat28828) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _SecretKeySpec28829;
		public SecretKeySpec(byte[] arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.SecretKeySpec._SecretKeySpec28829.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.SecretKeySpec._SecretKeySpec28829 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.SecretKeySpec.staticClass, "<init>", "([BLjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.SecretKeySpec.staticClass, global::javax.crypto.spec.SecretKeySpec._SecretKeySpec28829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SecretKeySpec28830;
		public SecretKeySpec(byte[] arg0, int arg1, int arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.SecretKeySpec._SecretKeySpec28830.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.SecretKeySpec._SecretKeySpec28830 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.SecretKeySpec.staticClass, "<init>", "([BIILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.SecretKeySpec.staticClass, global::javax.crypto.spec.SecretKeySpec._SecretKeySpec28830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static SecretKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.SecretKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/SecretKeySpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}