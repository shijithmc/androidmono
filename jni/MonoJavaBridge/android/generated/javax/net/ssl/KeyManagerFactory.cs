namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyManagerFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyManagerFactory()
		{
			InitJNI();
		}
		protected KeyManagerFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance29743;
		public static global::javax.net.ssl.KeyManagerFactory getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getInstance29743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.KeyManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance29744;
		public static global::javax.net.ssl.KeyManagerFactory getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getInstance29744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.KeyManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance29745;
		public static global::javax.net.ssl.KeyManagerFactory getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getInstance29745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.KeyManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _init29746;
		public virtual void init(java.security.KeyStore arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactory._init29746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._init29746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init29747;
		public virtual void init(javax.net.ssl.ManagerFactoryParameters arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactory._init29747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._init29747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm29748;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactory._getAlgorithm29748)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getAlgorithm29748)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider29749;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactory._getProvider29749)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getProvider29749)) as java.security.Provider;
		}
		public static global::java.lang.String DefaultAlgorithm
		{
			get
			{
				return getDefaultAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultAlgorithm29750;
		public static global::java.lang.String getDefaultAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getDefaultAlgorithm29750)) as java.lang.String;
		}
		public new global::javax.net.ssl.KeyManager[] KeyManagers
		{
			get
			{
				return getKeyManagers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyManagers29751;
		public virtual global::javax.net.ssl.KeyManager[] getKeyManagers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.KeyManager>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactory._getKeyManagers29751)) as javax.net.ssl.KeyManager[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.KeyManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getKeyManagers29751)) as javax.net.ssl.KeyManager[];
		}
		internal static global::MonoJavaBridge.MethodId _KeyManagerFactory29752;
		protected KeyManagerFactory(javax.net.ssl.KeyManagerFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._KeyManagerFactory29752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.KeyManagerFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/KeyManagerFactory"));
			global::javax.net.ssl.KeyManagerFactory._getInstance29743 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/KeyManagerFactory;");
			global::javax.net.ssl.KeyManagerFactory._getInstance29744 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/KeyManagerFactory;");
			global::javax.net.ssl.KeyManagerFactory._getInstance29745 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/KeyManagerFactory;");
			global::javax.net.ssl.KeyManagerFactory._init29746 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "init", "(Ljava/security/KeyStore;[C)V");
			global::javax.net.ssl.KeyManagerFactory._init29747 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "init", "(Ljavax/net/ssl/ManagerFactoryParameters;)V");
			global::javax.net.ssl.KeyManagerFactory._getAlgorithm29748 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.net.ssl.KeyManagerFactory._getProvider29749 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.net.ssl.KeyManagerFactory._getDefaultAlgorithm29750 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getDefaultAlgorithm", "()Ljava/lang/String;");
			global::javax.net.ssl.KeyManagerFactory._getKeyManagers29751 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getKeyManagers", "()[Ljavax/net/ssl/KeyManager;");
			global::javax.net.ssl.KeyManagerFactory._KeyManagerFactory29752 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "<init>", "(Ljavax/net/ssl/KeyManagerFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
