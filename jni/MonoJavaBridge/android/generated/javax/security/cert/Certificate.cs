namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.security.cert.Certificate_))]
	public abstract partial class Certificate : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Certificate()
		{
			InitJNI();
		}
		protected Certificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals30105;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.cert.Certificate._equals30105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._equals30105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30106;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode30107;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.security.cert.Certificate._hashCode30107);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._hashCode30107);
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded30108;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _verify30109;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _verify30110;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getPublicKey30111;
		public abstract global::java.security.PublicKey getPublicKey();
		internal static global::MonoJavaBridge.MethodId _Certificate30112;
		public Certificate()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._Certificate30112);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/Certificate"));
			global::javax.security.cert.Certificate._equals30105 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.security.cert.Certificate._toString30106 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.cert.Certificate._hashCode30107 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "hashCode", "()I");
			global::javax.security.cert.Certificate._getEncoded30108 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "getEncoded", "()[B");
			global::javax.security.cert.Certificate._verify30109 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::javax.security.cert.Certificate._verify30110 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::javax.security.cert.Certificate._getPublicKey30111 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
			global::javax.security.cert.Certificate._Certificate30112 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.security.cert.Certificate))]
	public sealed partial class Certificate_ : javax.security.cert.Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Certificate_()
		{
			InitJNI();
		}
		internal Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString30113;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_._toString30113)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._toString30113)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded30114;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_._getEncoded30114)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._getEncoded30114)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify30115;
		public override void verify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.Certificate_._verify30115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._verify30115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify30116;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.Certificate_._verify30116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._verify30116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey30117;
		public override global::java.security.PublicKey getPublicKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_._getPublicKey30117)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._getPublicKey30117)) as java.security.PublicKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/Certificate"));
			global::javax.security.cert.Certificate_._toString30113 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.cert.Certificate_._getEncoded30114 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "getEncoded", "()[B");
			global::javax.security.cert.Certificate_._verify30115 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::javax.security.cert.Certificate_._verify30116 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::javax.security.cert.Certificate_._getPublicKey30117 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
		}
	}
}
