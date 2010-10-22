namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyGenerator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyGenerator()
		{
			InitJNI();
		}
		protected KeyGenerator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28532;
		public static global::javax.crypto.KeyGenerator getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getInstance28532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28533;
		public static global::javax.crypto.KeyGenerator getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getInstance28533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.KeyGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28534;
		public static global::javax.crypto.KeyGenerator getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getInstance28534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _init28535;
		public virtual void init(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._init28535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init28535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init28536;
		public virtual void init(int arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._init28536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init28536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init28537;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._init28537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init28537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init28538;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._init28538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init28538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init28539;
		public virtual void init(java.security.SecureRandom arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._init28539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init28539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28540;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._getAlgorithm28540)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getAlgorithm28540)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider28541;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._getProvider28541)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getProvider28541)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _generateKey28542;
		public virtual global::javax.crypto.SecretKey generateKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._generateKey28542)) as javax.crypto.SecretKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._generateKey28542)) as javax.crypto.SecretKey;
		}
		internal static global::MonoJavaBridge.MethodId _KeyGenerator28543;
		protected KeyGenerator(javax.crypto.KeyGeneratorSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._KeyGenerator28543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyGenerator"));
			global::javax.crypto.KeyGenerator._getInstance28532 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/KeyGenerator;");
			global::javax.crypto.KeyGenerator._getInstance28533 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/KeyGenerator;");
			global::javax.crypto.KeyGenerator._getInstance28534 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/KeyGenerator;");
			global::javax.crypto.KeyGenerator._init28535 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(I)V");
			global::javax.crypto.KeyGenerator._init28536 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(ILjava/security/SecureRandom;)V");
			global::javax.crypto.KeyGenerator._init28537 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.KeyGenerator._init28538 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyGenerator._init28539 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyGenerator._getAlgorithm28540 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.KeyGenerator._getProvider28541 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.KeyGenerator._generateKey28542 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "generateKey", "()Ljavax/crypto/SecretKey;");
			global::javax.crypto.KeyGenerator._KeyGenerator28543 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "<init>", "(Ljavax/crypto/KeyGeneratorSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
