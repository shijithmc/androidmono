namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateFactory()
		{
			InitJNI();
		}
		protected CertificateFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23462;
		public static global::java.security.cert.CertificateFactory getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getInstance23462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertificateFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23463;
		public static global::java.security.cert.CertificateFactory getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getInstance23463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertificateFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23464;
		public static global::java.security.cert.CertificateFactory getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getInstance23464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertificateFactory;
		}
		public new global::java.lang.String Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType23465;
		public virtual global::java.lang.String getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._getType23465)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getType23465)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertificate23466;
		public virtual global::java.security.cert.Certificate generateCertificate(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertificate23466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertificate23466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertPath23467;
		public virtual global::java.security.cert.CertPath generateCertPath(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertPath23467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertPath23467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertPath23468;
		public virtual global::java.security.cert.CertPath generateCertPath(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertPath23468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertPath23468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertPath23469;
		public virtual global::java.security.cert.CertPath generateCertPath(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertPath23469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertPath23469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23470;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._getProvider23470)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getProvider23470)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _generateCRL23471;
		public virtual global::java.security.cert.CRL generateCRL(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCRL23471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCRL23471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
		}
		public new global::java.util.Iterator CertPathEncodings
		{
			get
			{
				return getCertPathEncodings();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertPathEncodings23472;
		public virtual global::java.util.Iterator getCertPathEncodings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._getCertPathEncodings23472)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getCertPathEncodings23472)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertificates23473;
		public virtual global::java.util.Collection generateCertificates(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertificates23473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertificates23473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _generateCRLs23474;
		public virtual global::java.util.Collection generateCRLs(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCRLs23474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCRLs23474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _CertificateFactory23475;
		protected CertificateFactory(java.security.cert.CertificateFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._CertificateFactory23475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactory"));
			global::java.security.cert.CertificateFactory._getInstance23462 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertificateFactory;");
			global::java.security.cert.CertificateFactory._getInstance23463 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertificateFactory;");
			global::java.security.cert.CertificateFactory._getInstance23464 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertificateFactory;");
			global::java.security.cert.CertificateFactory._getType23465 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.CertificateFactory._generateCertificate23466 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;");
			global::java.security.cert.CertificateFactory._generateCertPath23467 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactory._generateCertPath23468 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactory._generateCertPath23469 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactory._getProvider23470 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.cert.CertificateFactory._generateCRL23471 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;");
			global::java.security.cert.CertificateFactory._getCertPathEncodings23472 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getCertPathEncodings", "()Ljava/util/Iterator;");
			global::java.security.cert.CertificateFactory._generateCertificates23473 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactory._generateCRLs23474 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactory._CertificateFactory23475 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "<init>", "(Ljava/security/cert/CertificateFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
