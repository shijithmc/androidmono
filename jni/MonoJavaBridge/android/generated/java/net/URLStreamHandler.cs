namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.URLStreamHandler_))]
	public abstract partial class URLStreamHandler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URLStreamHandler()
		{
			InitJNI();
		}
		protected URLStreamHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals13965;
		protected virtual bool equals(java.net.URL arg0, java.net.URL arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLStreamHandler._equals13965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._equals13965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13966;
		protected virtual int hashCode(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLStreamHandler._hashCode13966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._hashCode13966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultPort13967;
		protected virtual int getDefaultPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLStreamHandler._getDefaultPort13967);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._getDefaultPort13967);
		}
		internal static global::MonoJavaBridge.MethodId _sameFile13968;
		protected virtual bool sameFile(java.net.URL arg0, java.net.URL arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLStreamHandler._sameFile13968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._sameFile13968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toExternalForm13969;
		protected virtual global::java.lang.String toExternalForm(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLStreamHandler._toExternalForm13969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._toExternalForm13969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _openConnection13970;
		protected virtual global::java.net.URLConnection openConnection(java.net.URL arg0, java.net.Proxy arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLStreamHandler._openConnection13970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URLConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._openConnection13970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URLConnection;
		}
		internal static global::MonoJavaBridge.MethodId _openConnection13971;
		protected abstract global::java.net.URLConnection openConnection(java.net.URL arg0);
		internal static global::MonoJavaBridge.MethodId _parseURL13972;
		protected virtual void parseURL(java.net.URL arg0, java.lang.String arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLStreamHandler._parseURL13972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._parseURL13972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress13973;
		protected virtual global::java.net.InetAddress getHostAddress(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLStreamHandler._getHostAddress13973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._getHostAddress13973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _hostsEqual13974;
		protected virtual bool hostsEqual(java.net.URL arg0, java.net.URL arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLStreamHandler._hostsEqual13974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._hostsEqual13974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setURL13975;
		protected virtual void setURL(java.net.URL arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLStreamHandler._setURL13975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._setURL13975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _setURL13976;
		protected virtual void setURL(java.net.URL arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLStreamHandler._setURL13976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._setURL13976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _URLStreamHandler13977;
		public URLStreamHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._URLStreamHandler13977);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLStreamHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLStreamHandler"));
			global::java.net.URLStreamHandler._equals13965 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "equals", "(Ljava/net/URL;Ljava/net/URL;)Z");
			global::java.net.URLStreamHandler._hashCode13966 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "hashCode", "(Ljava/net/URL;)I");
			global::java.net.URLStreamHandler._getDefaultPort13967 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "getDefaultPort", "()I");
			global::java.net.URLStreamHandler._sameFile13968 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "sameFile", "(Ljava/net/URL;Ljava/net/URL;)Z");
			global::java.net.URLStreamHandler._toExternalForm13969 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "toExternalForm", "(Ljava/net/URL;)Ljava/lang/String;");
			global::java.net.URLStreamHandler._openConnection13970 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "openConnection", "(Ljava/net/URL;Ljava/net/Proxy;)Ljava/net/URLConnection;");
			global::java.net.URLStreamHandler._openConnection13971 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "openConnection", "(Ljava/net/URL;)Ljava/net/URLConnection;");
			global::java.net.URLStreamHandler._parseURL13972 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "parseURL", "(Ljava/net/URL;Ljava/lang/String;II)V");
			global::java.net.URLStreamHandler._getHostAddress13973 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "getHostAddress", "(Ljava/net/URL;)Ljava/net/InetAddress;");
			global::java.net.URLStreamHandler._hostsEqual13974 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "hostsEqual", "(Ljava/net/URL;Ljava/net/URL;)Z");
			global::java.net.URLStreamHandler._setURL13975 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "setURL", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLStreamHandler._setURL13976 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "setURL", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLStreamHandler._URLStreamHandler13977 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.URLStreamHandler))]
	public sealed partial class URLStreamHandler_ : java.net.URLStreamHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URLStreamHandler_()
		{
			InitJNI();
		}
		internal URLStreamHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _openConnection13978;
		protected override global::java.net.URLConnection openConnection(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLStreamHandler_._openConnection13978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLStreamHandler_.staticClass, global::java.net.URLStreamHandler_._openConnection13978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLConnection;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLStreamHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLStreamHandler"));
			global::java.net.URLStreamHandler_._openConnection13978 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler_.staticClass, "openConnection", "(Ljava/net/URL;)Ljava/net/URLConnection;");
		}
	}
}
