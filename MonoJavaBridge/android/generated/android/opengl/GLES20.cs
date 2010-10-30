namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLES20 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GLES20(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glActiveTexture8930;
		public static void glActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glActiveTexture8930.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glActiveTexture8930 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glActiveTexture", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glActiveTexture8930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBindTexture8931;
		public static void glBindTexture(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glBindTexture8931.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glBindTexture8931 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBindTexture", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBindTexture8931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFunc8932;
		public static void glBlendFunc(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glBlendFunc8932.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glBlendFunc8932 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBlendFunc", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBlendFunc8932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClear8933;
		public static void glClear(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glClear8933.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glClear8933 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glClear", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glClear8933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColor8934;
		public static void glClearColor(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glClearColor8934.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glClearColor8934 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glClearColor", "(FFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glClearColor8934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthf8935;
		public static void glClearDepthf(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glClearDepthf8935.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glClearDepthf8935 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glClearDepthf", "(F)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glClearDepthf8935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearStencil8936;
		public static void glClearStencil(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glClearStencil8936.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glClearStencil8936 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glClearStencil", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glClearStencil8936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glColorMask8937;
		public static void glColorMask(bool arg0, bool arg1, bool arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glColorMask8937.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glColorMask8937 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glColorMask", "(ZZZZ)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glColorMask8937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexImage2D8938;
		public static void glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glCompressedTexImage2D8938.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glCompressedTexImage2D8938 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCompressedTexImage2D8938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexSubImage2D8939;
		public static void glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glCompressedTexSubImage2D8939.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glCompressedTexSubImage2D8939 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCompressedTexSubImage2D8939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexImage2D8940;
		public static void glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glCopyTexImage2D8940.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glCopyTexImage2D8940 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCopyTexImage2D8940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexSubImage2D8941;
		public static void glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glCopyTexSubImage2D8941.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glCopyTexSubImage2D8941 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCopyTexSubImage2D8941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCullFace8942;
		public static void glCullFace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glCullFace8942.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glCullFace8942 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCullFace", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCullFace8942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures8943;
		public static void glDeleteTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDeleteTextures8943.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDeleteTextures8943 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteTextures", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteTextures8943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures8944;
		public static void glDeleteTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDeleteTextures8944.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDeleteTextures8944 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteTextures8944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthFunc8945;
		public static void glDepthFunc(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDepthFunc8945.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDepthFunc8945 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDepthFunc", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDepthFunc8945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthMask8946;
		public static void glDepthMask(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDepthMask8946.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDepthMask8946 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDepthMask", "(Z)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDepthMask8946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangef8947;
		public static void glDepthRangef(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDepthRangef8947.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDepthRangef8947 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDepthRangef", "(FF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDepthRangef8947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDisable8948;
		public static void glDisable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDisable8948.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDisable8948 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDisable", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDisable8948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawArrays8949;
		public static void glDrawArrays(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDrawArrays8949.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDrawArrays8949 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDrawArrays", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDrawArrays8949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements8950;
		public static void glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDrawElements8950.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDrawElements8950 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDrawElements8950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glEnable8951;
		public static void glEnable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glEnable8951.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glEnable8951 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glEnable", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glEnable8951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFinish8952;
		public static void glFinish()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glFinish8952.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glFinish8952 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glFinish", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glFinish8952);
		}
		internal static global::MonoJavaBridge.MethodId _glFlush8953;
		public static void glFlush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glFlush8953.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glFlush8953 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glFlush", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glFlush8953);
		}
		internal static global::MonoJavaBridge.MethodId _glFrontFace8954;
		public static void glFrontFace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glFrontFace8954.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glFrontFace8954 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glFrontFace", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glFrontFace8954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures8955;
		public static void glGenTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGenTextures8955.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGenTextures8955 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenTextures", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenTextures8955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures8956;
		public static void glGenTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGenTextures8956.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGenTextures8956 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenTextures8956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetError8957;
		public static int glGetError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetError8957.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetError8957 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetError", "()I");
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetError8957);
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv8958;
		public static void glGetIntegerv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetIntegerv8958.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetIntegerv8958 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetIntegerv8958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv8959;
		public static void glGetIntegerv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetIntegerv8959.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetIntegerv8959 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetIntegerv", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetIntegerv8959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetString8960;
		public static global::java.lang.String glGetString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetString8960.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetString8960 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetString8960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _glHint8961;
		public static void glHint(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glHint8961.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glHint8961 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glHint", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glHint8961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidth8962;
		public static void glLineWidth(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glLineWidth8962.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glLineWidth8962 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glLineWidth", "(F)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glLineWidth8962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPixelStorei8963;
		public static void glPixelStorei(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glPixelStorei8963.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glPixelStorei8963 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glPixelStorei", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glPixelStorei8963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffset8964;
		public static void glPolygonOffset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glPolygonOffset8964.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glPolygonOffset8964 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glPolygonOffset", "(FF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glPolygonOffset8964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glReadPixels8965;
		public static void glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glReadPixels8965.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glReadPixels8965 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glReadPixels8965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoverage8966;
		public static void glSampleCoverage(float arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glSampleCoverage8966.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glSampleCoverage8966 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glSampleCoverage", "(FZ)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glSampleCoverage8966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glScissor8967;
		public static void glScissor(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glScissor8967.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glScissor8967 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glScissor", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glScissor8967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilFunc8968;
		public static void glStencilFunc(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glStencilFunc8968.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glStencilFunc8968 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glStencilFunc", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glStencilFunc8968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilMask8969;
		public static void glStencilMask(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glStencilMask8969.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glStencilMask8969 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glStencilMask", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glStencilMask8969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilOp8970;
		public static void glStencilOp(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glStencilOp8970.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glStencilOp8970 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glStencilOp", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glStencilOp8970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexImage2D8971;
		public static void glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glTexImage2D8971.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glTexImage2D8971 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexImage2D8971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterf8972;
		public static void glTexParameterf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glTexParameterf8972.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glTexParameterf8972 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexParameterf", "(IIF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexParameterf8972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexSubImage2D8973;
		public static void glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glTexSubImage2D8973.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glTexSubImage2D8973 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexSubImage2D8973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glViewport8974;
		public static void glViewport(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glViewport8974.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glViewport8974 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glViewport", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glViewport8974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBindBuffer8975;
		public static void glBindBuffer(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glBindBuffer8975.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glBindBuffer8975 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBindBuffer", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBindBuffer8975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBufferData8976;
		public static void glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glBufferData8976.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glBufferData8976 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBufferData", "(IILjava/nio/Buffer;I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBufferData8976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBufferSubData8977;
		public static void glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glBufferSubData8977.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glBufferSubData8977 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBufferSubData", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBufferSubData8977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteBuffers8978;
		public static void glDeleteBuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDeleteBuffers8978.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDeleteBuffers8978 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteBuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteBuffers8978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteBuffers8979;
		public static void glDeleteBuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDeleteBuffers8979.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDeleteBuffers8979 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteBuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteBuffers8979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenBuffers8980;
		public static void glGenBuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGenBuffers8980.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGenBuffers8980 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenBuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenBuffers8980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenBuffers8981;
		public static void glGenBuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGenBuffers8981.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGenBuffers8981 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenBuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenBuffers8981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBooleanv8982;
		public static void glGetBooleanv(int arg0, bool[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetBooleanv8982.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetBooleanv8982 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetBooleanv", "(I[ZI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetBooleanv8982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBooleanv8983;
		public static void glGetBooleanv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetBooleanv8983.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetBooleanv8983 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetBooleanv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetBooleanv8983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBufferParameteriv8984;
		public static void glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetBufferParameteriv8984.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetBufferParameteriv8984 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetBufferParameteriv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetBufferParameteriv8984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBufferParameteriv8985;
		public static void glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetBufferParameteriv8985.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetBufferParameteriv8985 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetBufferParameteriv8985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFloatv8986;
		public static void glGetFloatv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetFloatv8986.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetFloatv8986 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetFloatv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetFloatv8986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFloatv8987;
		public static void glGetFloatv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetFloatv8987.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetFloatv8987 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetFloatv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetFloatv8987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterfv8988;
		public static void glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetTexParameterfv8988.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetTexParameterfv8988 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetTexParameterfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetTexParameterfv8988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterfv8989;
		public static void glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetTexParameterfv8989.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetTexParameterfv8989 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetTexParameterfv8989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameteriv8990;
		public static void glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetTexParameteriv8990.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetTexParameteriv8990 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetTexParameteriv8990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameteriv8991;
		public static void glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetTexParameteriv8991.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetTexParameteriv8991 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetTexParameteriv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetTexParameteriv8991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glIsBuffer8992;
		public static bool glIsBuffer(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glIsBuffer8992.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glIsBuffer8992 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsBuffer", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsBuffer8992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsEnabled8993;
		public static bool glIsEnabled(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glIsEnabled8993.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glIsEnabled8993 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsEnabled", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsEnabled8993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsTexture8994;
		public static bool glIsTexture(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glIsTexture8994.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glIsTexture8994 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsTexture", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsTexture8994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv8995;
		public static void glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glTexParameterfv8995.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glTexParameterfv8995 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexParameterfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexParameterfv8995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv8996;
		public static void glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glTexParameterfv8996.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glTexParameterfv8996 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexParameterfv8996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteri8997;
		public static void glTexParameteri(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glTexParameteri8997.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glTexParameteri8997 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexParameteri", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexParameteri8997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteriv8998;
		public static void glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glTexParameteriv8998.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glTexParameteriv8998 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexParameteriv8998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteriv8999;
		public static void glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glTexParameteriv8999.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glTexParameteriv8999 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexParameteriv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexParameteriv8999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glAttachShader9000;
		public static void glAttachShader(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glAttachShader9000.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glAttachShader9000 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glAttachShader", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glAttachShader9000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBindAttribLocation9001;
		public static void glBindAttribLocation(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glBindAttribLocation9001.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glBindAttribLocation9001 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBindAttribLocation", "(IILjava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBindAttribLocation9001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glBindFramebuffer9002;
		public static void glBindFramebuffer(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glBindFramebuffer9002.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glBindFramebuffer9002 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBindFramebuffer", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBindFramebuffer9002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBindRenderbuffer9003;
		public static void glBindRenderbuffer(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glBindRenderbuffer9003.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glBindRenderbuffer9003 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBindRenderbuffer", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBindRenderbuffer9003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendColor9004;
		public static void glBlendColor(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glBlendColor9004.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glBlendColor9004 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBlendColor", "(FFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBlendColor9004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendEquation9005;
		public static void glBlendEquation(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glBlendEquation9005.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glBlendEquation9005 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBlendEquation", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBlendEquation9005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendEquationSeparate9006;
		public static void glBlendEquationSeparate(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glBlendEquationSeparate9006.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glBlendEquationSeparate9006 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBlendEquationSeparate", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBlendEquationSeparate9006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFuncSeparate9007;
		public static void glBlendFuncSeparate(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glBlendFuncSeparate9007.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glBlendFuncSeparate9007 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBlendFuncSeparate", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBlendFuncSeparate9007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glCheckFramebufferStatus9008;
		public static int glCheckFramebufferStatus(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glCheckFramebufferStatus9008.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glCheckFramebufferStatus9008 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCheckFramebufferStatus", "(I)I");
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCheckFramebufferStatus9008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glCompileShader9009;
		public static void glCompileShader(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glCompileShader9009.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glCompileShader9009 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCompileShader", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCompileShader9009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glCreateProgram9010;
		public static int glCreateProgram()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glCreateProgram9010.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glCreateProgram9010 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCreateProgram", "()I");
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCreateProgram9010);
		}
		internal static global::MonoJavaBridge.MethodId _glCreateShader9011;
		public static int glCreateShader(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glCreateShader9011.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glCreateShader9011 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCreateShader", "(I)I");
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCreateShader9011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteFramebuffers9012;
		public static void glDeleteFramebuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDeleteFramebuffers9012.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDeleteFramebuffers9012 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteFramebuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteFramebuffers9012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteFramebuffers9013;
		public static void glDeleteFramebuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDeleteFramebuffers9013.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDeleteFramebuffers9013 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteFramebuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteFramebuffers9013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteProgram9014;
		public static void glDeleteProgram(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDeleteProgram9014.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDeleteProgram9014 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteProgram", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteProgram9014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteRenderbuffers9015;
		public static void glDeleteRenderbuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDeleteRenderbuffers9015.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDeleteRenderbuffers9015 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteRenderbuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteRenderbuffers9015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteRenderbuffers9016;
		public static void glDeleteRenderbuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDeleteRenderbuffers9016.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDeleteRenderbuffers9016 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteRenderbuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteRenderbuffers9016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteShader9017;
		public static void glDeleteShader(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDeleteShader9017.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDeleteShader9017 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteShader", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteShader9017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDetachShader9018;
		public static void glDetachShader(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDetachShader9018.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDetachShader9018 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDetachShader", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDetachShader9018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDisableVertexAttribArray9019;
		public static void glDisableVertexAttribArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glDisableVertexAttribArray9019.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glDisableVertexAttribArray9019 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDisableVertexAttribArray", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDisableVertexAttribArray9019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glEnableVertexAttribArray9020;
		public static void glEnableVertexAttribArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glEnableVertexAttribArray9020.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glEnableVertexAttribArray9020 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glEnableVertexAttribArray", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glEnableVertexAttribArray9020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFramebufferRenderbuffer9021;
		public static void glFramebufferRenderbuffer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glFramebufferRenderbuffer9021.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glFramebufferRenderbuffer9021 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glFramebufferRenderbuffer", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glFramebufferRenderbuffer9021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glFramebufferTexture2D9022;
		public static void glFramebufferTexture2D(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glFramebufferTexture2D9022.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glFramebufferTexture2D9022 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glFramebufferTexture2D", "(IIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glFramebufferTexture2D9022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glGenerateMipmap9023;
		public static void glGenerateMipmap(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGenerateMipmap9023.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGenerateMipmap9023 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenerateMipmap", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenerateMipmap9023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glGenFramebuffers9024;
		public static void glGenFramebuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGenFramebuffers9024.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGenFramebuffers9024 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenFramebuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenFramebuffers9024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenFramebuffers9025;
		public static void glGenFramebuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGenFramebuffers9025.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGenFramebuffers9025 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenFramebuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenFramebuffers9025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenRenderbuffers9026;
		public static void glGenRenderbuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGenRenderbuffers9026.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGenRenderbuffers9026 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenRenderbuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenRenderbuffers9026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenRenderbuffers9027;
		public static void glGenRenderbuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGenRenderbuffers9027.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGenRenderbuffers9027 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenRenderbuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenRenderbuffers9027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetActiveAttrib9028;
		public static void glGetActiveAttrib(int arg0, int arg1, int arg2, int[] arg3, int arg4, int[] arg5, int arg6, int[] arg7, int arg8, byte[] arg9, int arg10)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetActiveAttrib9028.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetActiveAttrib9028 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetActiveAttrib", "(III[II[II[II[BI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetActiveAttrib9028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
		}
		internal static global::MonoJavaBridge.MethodId _glGetActiveAttrib9029;
		public static void glGetActiveAttrib(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3, java.nio.IntBuffer arg4, java.nio.IntBuffer arg5, byte arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetActiveAttrib9029.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetActiveAttrib9029 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetActiveAttrib", "(IIILjava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;B)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetActiveAttrib9029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _glGetActiveUniform9030;
		public static void glGetActiveUniform(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3, java.nio.IntBuffer arg4, java.nio.IntBuffer arg5, byte arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetActiveUniform9030.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetActiveUniform9030 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetActiveUniform", "(IIILjava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;B)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetActiveUniform9030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _glGetActiveUniform9031;
		public static void glGetActiveUniform(int arg0, int arg1, int arg2, int[] arg3, int arg4, int[] arg5, int arg6, int[] arg7, int arg8, byte[] arg9, int arg10)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetActiveUniform9031.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetActiveUniform9031 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetActiveUniform", "(III[II[II[II[BI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetActiveUniform9031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
		}
		internal static global::MonoJavaBridge.MethodId _glGetAttachedShaders9032;
		public static void glGetAttachedShaders(int arg0, int arg1, int[] arg2, int arg3, int[] arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetAttachedShaders9032.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetAttachedShaders9032 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetAttachedShaders", "(II[II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetAttachedShaders9032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glGetAttachedShaders9033;
		public static void glGetAttachedShaders(int arg0, int arg1, java.nio.IntBuffer arg2, java.nio.IntBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetAttachedShaders9033.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetAttachedShaders9033 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetAttachedShaders", "(IILjava/nio/IntBuffer;Ljava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetAttachedShaders9033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetAttribLocation9034;
		public static int glGetAttribLocation(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetAttribLocation9034.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetAttribLocation9034 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetAttribLocation", "(ILjava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetAttribLocation9034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFramebufferAttachmentParameteriv9035;
		public static void glGetFramebufferAttachmentParameteriv(int arg0, int arg1, int arg2, int[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetFramebufferAttachmentParameteriv9035.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetFramebufferAttachmentParameteriv9035 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetFramebufferAttachmentParameteriv", "(III[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetFramebufferAttachmentParameteriv9035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFramebufferAttachmentParameteriv9036;
		public static void glGetFramebufferAttachmentParameteriv(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetFramebufferAttachmentParameteriv9036.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetFramebufferAttachmentParameteriv9036 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetFramebufferAttachmentParameteriv", "(IIILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetFramebufferAttachmentParameteriv9036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetProgramiv9037;
		public static void glGetProgramiv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetProgramiv9037.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetProgramiv9037 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetProgramiv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetProgramiv9037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetProgramiv9038;
		public static void glGetProgramiv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetProgramiv9038.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetProgramiv9038 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetProgramiv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetProgramiv9038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetProgramInfoLog9039;
		public static global::java.lang.String glGetProgramInfoLog(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetProgramInfoLog9039.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetProgramInfoLog9039 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetProgramInfoLog", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetProgramInfoLog9039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _glGetRenderbufferParameteriv9040;
		public static void glGetRenderbufferParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetRenderbufferParameteriv9040.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetRenderbufferParameteriv9040 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetRenderbufferParameteriv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetRenderbufferParameteriv9040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetRenderbufferParameteriv9041;
		public static void glGetRenderbufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetRenderbufferParameteriv9041.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetRenderbufferParameteriv9041 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetRenderbufferParameteriv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetRenderbufferParameteriv9041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetShaderiv9042;
		public static void glGetShaderiv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetShaderiv9042.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetShaderiv9042 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderiv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderiv9042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetShaderiv9043;
		public static void glGetShaderiv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetShaderiv9043.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetShaderiv9043 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderiv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderiv9043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetShaderInfoLog9044;
		public static global::java.lang.String glGetShaderInfoLog(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetShaderInfoLog9044.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetShaderInfoLog9044 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderInfoLog", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderInfoLog9044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _glGetShaderPrecisionFormat9045;
		public static void glGetShaderPrecisionFormat(int arg0, int arg1, java.nio.IntBuffer arg2, java.nio.IntBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetShaderPrecisionFormat9045.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetShaderPrecisionFormat9045 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderPrecisionFormat", "(IILjava/nio/IntBuffer;Ljava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderPrecisionFormat9045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetShaderPrecisionFormat9046;
		public static void glGetShaderPrecisionFormat(int arg0, int arg1, int[] arg2, int arg3, int[] arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetShaderPrecisionFormat9046.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetShaderPrecisionFormat9046 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderPrecisionFormat", "(II[II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderPrecisionFormat9046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glGetShaderSource9047;
		public static void glGetShaderSource(int arg0, int arg1, java.nio.IntBuffer arg2, byte arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetShaderSource9047.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetShaderSource9047 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderSource", "(IILjava/nio/IntBuffer;B)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderSource9047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetShaderSource9048;
		public static void glGetShaderSource(int arg0, int arg1, int[] arg2, int arg3, byte[] arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetShaderSource9048.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetShaderSource9048 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderSource", "(II[II[BI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderSource9048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glGetUniformfv9049;
		public static void glGetUniformfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetUniformfv9049.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetUniformfv9049 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetUniformfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetUniformfv9049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetUniformfv9050;
		public static void glGetUniformfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetUniformfv9050.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetUniformfv9050 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetUniformfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetUniformfv9050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetUniformiv9051;
		public static void glGetUniformiv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetUniformiv9051.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetUniformiv9051 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetUniformiv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetUniformiv9051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetUniformiv9052;
		public static void glGetUniformiv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetUniformiv9052.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetUniformiv9052 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetUniformiv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetUniformiv9052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetUniformLocation9053;
		public static int glGetUniformLocation(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetUniformLocation9053.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetUniformLocation9053 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetUniformLocation", "(ILjava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetUniformLocation9053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetVertexAttribfv9054;
		public static void glGetVertexAttribfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetVertexAttribfv9054.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetVertexAttribfv9054 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetVertexAttribfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetVertexAttribfv9054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetVertexAttribfv9055;
		public static void glGetVertexAttribfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetVertexAttribfv9055.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetVertexAttribfv9055 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetVertexAttribfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetVertexAttribfv9055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetVertexAttribiv9056;
		public static void glGetVertexAttribiv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetVertexAttribiv9056.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetVertexAttribiv9056 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetVertexAttribiv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetVertexAttribiv9056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetVertexAttribiv9057;
		public static void glGetVertexAttribiv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glGetVertexAttribiv9057.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glGetVertexAttribiv9057 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetVertexAttribiv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetVertexAttribiv9057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glIsFramebuffer9058;
		public static bool glIsFramebuffer(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glIsFramebuffer9058.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glIsFramebuffer9058 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsFramebuffer", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsFramebuffer9058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsProgram9059;
		public static bool glIsProgram(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glIsProgram9059.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glIsProgram9059 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsProgram", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsProgram9059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsRenderbuffer9060;
		public static bool glIsRenderbuffer(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glIsRenderbuffer9060.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glIsRenderbuffer9060 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsRenderbuffer", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsRenderbuffer9060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsShader9061;
		public static bool glIsShader(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glIsShader9061.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glIsShader9061 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsShader", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsShader9061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLinkProgram9062;
		public static void glLinkProgram(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glLinkProgram9062.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glLinkProgram9062 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glLinkProgram", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glLinkProgram9062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glReleaseShaderCompiler9063;
		public static void glReleaseShaderCompiler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glReleaseShaderCompiler9063.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glReleaseShaderCompiler9063 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glReleaseShaderCompiler", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glReleaseShaderCompiler9063);
		}
		internal static global::MonoJavaBridge.MethodId _glRenderbufferStorage9064;
		public static void glRenderbufferStorage(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glRenderbufferStorage9064.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glRenderbufferStorage9064 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glRenderbufferStorage", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glRenderbufferStorage9064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glShaderBinary9065;
		public static void glShaderBinary(int arg0, java.nio.IntBuffer arg1, int arg2, java.nio.Buffer arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glShaderBinary9065.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glShaderBinary9065 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glShaderBinary", "(ILjava/nio/IntBuffer;ILjava/nio/Buffer;I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glShaderBinary9065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glShaderBinary9066;
		public static void glShaderBinary(int arg0, int[] arg1, int arg2, int arg3, java.nio.Buffer arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glShaderBinary9066.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glShaderBinary9066 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glShaderBinary", "(I[IIILjava/nio/Buffer;I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glShaderBinary9066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glShaderSource9067;
		public static void glShaderSource(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glShaderSource9067.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glShaderSource9067 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glShaderSource", "(ILjava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glShaderSource9067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilFuncSeparate9068;
		public static void glStencilFuncSeparate(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glStencilFuncSeparate9068.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glStencilFuncSeparate9068 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glStencilFuncSeparate", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glStencilFuncSeparate9068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilMaskSeparate9069;
		public static void glStencilMaskSeparate(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glStencilMaskSeparate9069.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glStencilMaskSeparate9069 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glStencilMaskSeparate", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glStencilMaskSeparate9069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilOpSeparate9070;
		public static void glStencilOpSeparate(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glStencilOpSeparate9070.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glStencilOpSeparate9070 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glStencilOpSeparate", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glStencilOpSeparate9070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform1f9071;
		public static void glUniform1f(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform1f9071.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform1f9071 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform1f", "(IF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform1f9071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform1fv9072;
		public static void glUniform1fv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform1fv9072.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform1fv9072 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform1fv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform1fv9072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform1fv9073;
		public static void glUniform1fv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform1fv9073.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform1fv9073 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform1fv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform1fv9073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform1i9074;
		public static void glUniform1i(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform1i9074.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform1i9074 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform1i", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform1i9074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform1iv9075;
		public static void glUniform1iv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform1iv9075.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform1iv9075 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform1iv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform1iv9075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform1iv9076;
		public static void glUniform1iv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform1iv9076.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform1iv9076 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform1iv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform1iv9076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform2f9077;
		public static void glUniform2f(int arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform2f9077.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform2f9077 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform2f", "(IFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform2f9077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform2fv9078;
		public static void glUniform2fv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform2fv9078.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform2fv9078 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform2fv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform2fv9078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform2fv9079;
		public static void glUniform2fv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform2fv9079.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform2fv9079 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform2fv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform2fv9079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform2i9080;
		public static void glUniform2i(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform2i9080.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform2i9080 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform2i", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform2i9080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform2iv9081;
		public static void glUniform2iv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform2iv9081.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform2iv9081 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform2iv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform2iv9081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform2iv9082;
		public static void glUniform2iv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform2iv9082.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform2iv9082 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform2iv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform2iv9082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform3f9083;
		public static void glUniform3f(int arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform3f9083.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform3f9083 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform3f", "(IFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform3f9083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform3fv9084;
		public static void glUniform3fv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform3fv9084.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform3fv9084 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform3fv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform3fv9084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform3fv9085;
		public static void glUniform3fv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform3fv9085.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform3fv9085 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform3fv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform3fv9085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform3i9086;
		public static void glUniform3i(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform3i9086.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform3i9086 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform3i", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform3i9086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform3iv9087;
		public static void glUniform3iv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform3iv9087.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform3iv9087 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform3iv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform3iv9087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform3iv9088;
		public static void glUniform3iv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform3iv9088.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform3iv9088 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform3iv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform3iv9088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform4f9089;
		public static void glUniform4f(int arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform4f9089.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform4f9089 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform4f", "(IFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform4f9089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform4fv9090;
		public static void glUniform4fv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform4fv9090.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform4fv9090 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform4fv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform4fv9090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform4fv9091;
		public static void glUniform4fv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform4fv9091.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform4fv9091 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform4fv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform4fv9091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform4i9092;
		public static void glUniform4i(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform4i9092.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform4i9092 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform4i", "(IIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform4i9092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform4iv9093;
		public static void glUniform4iv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform4iv9093.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform4iv9093 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform4iv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform4iv9093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glUniform4iv9094;
		public static void glUniform4iv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniform4iv9094.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniform4iv9094 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform4iv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform4iv9094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniformMatrix2fv9095;
		public static void glUniformMatrix2fv(int arg0, int arg1, bool arg2, java.nio.FloatBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniformMatrix2fv9095.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniformMatrix2fv9095 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniformMatrix2fv", "(IIZLjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniformMatrix2fv9095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniformMatrix2fv9096;
		public static void glUniformMatrix2fv(int arg0, int arg1, bool arg2, float[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniformMatrix2fv9096.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniformMatrix2fv9096 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniformMatrix2fv", "(IIZ[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniformMatrix2fv9096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glUniformMatrix3fv9097;
		public static void glUniformMatrix3fv(int arg0, int arg1, bool arg2, java.nio.FloatBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniformMatrix3fv9097.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniformMatrix3fv9097 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniformMatrix3fv", "(IIZLjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniformMatrix3fv9097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniformMatrix3fv9098;
		public static void glUniformMatrix3fv(int arg0, int arg1, bool arg2, float[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniformMatrix3fv9098.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniformMatrix3fv9098 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniformMatrix3fv", "(IIZ[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniformMatrix3fv9098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glUniformMatrix4fv9099;
		public static void glUniformMatrix4fv(int arg0, int arg1, bool arg2, java.nio.FloatBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniformMatrix4fv9099.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniformMatrix4fv9099 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniformMatrix4fv", "(IIZLjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniformMatrix4fv9099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glUniformMatrix4fv9100;
		public static void glUniformMatrix4fv(int arg0, int arg1, bool arg2, float[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUniformMatrix4fv9100.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUniformMatrix4fv9100 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniformMatrix4fv", "(IIZ[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniformMatrix4fv9100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glUseProgram9101;
		public static void glUseProgram(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glUseProgram9101.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glUseProgram9101 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUseProgram", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUseProgram9101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glValidateProgram9102;
		public static void glValidateProgram(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glValidateProgram9102.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glValidateProgram9102 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glValidateProgram", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glValidateProgram9102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttrib1f9103;
		public static void glVertexAttrib1f(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttrib1f9103.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttrib1f9103 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib1f", "(IF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib1f9103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttrib1fv9104;
		public static void glVertexAttrib1fv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttrib1fv9104.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttrib1fv9104 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib1fv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib1fv9104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttrib1fv9105;
		public static void glVertexAttrib1fv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttrib1fv9105.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttrib1fv9105 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib1fv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib1fv9105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttrib2f9106;
		public static void glVertexAttrib2f(int arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttrib2f9106.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttrib2f9106 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib2f", "(IFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib2f9106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttrib2fv9107;
		public static void glVertexAttrib2fv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttrib2fv9107.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttrib2fv9107 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib2fv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib2fv9107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttrib2fv9108;
		public static void glVertexAttrib2fv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttrib2fv9108.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttrib2fv9108 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib2fv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib2fv9108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttrib3f9109;
		public static void glVertexAttrib3f(int arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttrib3f9109.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttrib3f9109 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib3f", "(IFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib3f9109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttrib3fv9110;
		public static void glVertexAttrib3fv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttrib3fv9110.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttrib3fv9110 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib3fv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib3fv9110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttrib3fv9111;
		public static void glVertexAttrib3fv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttrib3fv9111.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttrib3fv9111 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib3fv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib3fv9111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttrib4f9112;
		public static void glVertexAttrib4f(int arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttrib4f9112.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttrib4f9112 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib4f", "(IFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib4f9112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttrib4fv9113;
		public static void glVertexAttrib4fv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttrib4fv9113.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttrib4fv9113 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib4fv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib4fv9113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttrib4fv9114;
		public static void glVertexAttrib4fv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttrib4fv9114.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttrib4fv9114 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib4fv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib4fv9114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexAttribPointer9115;
		public static void glVertexAttribPointer(int arg0, int arg1, int arg2, bool arg3, int arg4, java.nio.Buffer arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._glVertexAttribPointer9115.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._glVertexAttribPointer9115 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttribPointer", "(IIIZILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttribPointer9115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _GLES209116;
		public GLES20() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._GLES209116.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._GLES209116 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._GLES209116);
			Init(@__env, handle);
		}
		public static int GL_ACTIVE_TEXTURE
		{
			get
			{
				return 34016;
			}
		}
		public static int GL_DEPTH_BUFFER_BIT
		{
			get
			{
				return 256;
			}
		}
		public static int GL_STENCIL_BUFFER_BIT
		{
			get
			{
				return 1024;
			}
		}
		public static int GL_COLOR_BUFFER_BIT
		{
			get
			{
				return 16384;
			}
		}
		public static int GL_FALSE
		{
			get
			{
				return 0;
			}
		}
		public static int GL_TRUE
		{
			get
			{
				return 1;
			}
		}
		public static int GL_POINTS
		{
			get
			{
				return 0;
			}
		}
		public static int GL_LINES
		{
			get
			{
				return 1;
			}
		}
		public static int GL_LINE_LOOP
		{
			get
			{
				return 2;
			}
		}
		public static int GL_LINE_STRIP
		{
			get
			{
				return 3;
			}
		}
		public static int GL_TRIANGLES
		{
			get
			{
				return 4;
			}
		}
		public static int GL_TRIANGLE_STRIP
		{
			get
			{
				return 5;
			}
		}
		public static int GL_TRIANGLE_FAN
		{
			get
			{
				return 6;
			}
		}
		public static int GL_ZERO
		{
			get
			{
				return 0;
			}
		}
		public static int GL_ONE
		{
			get
			{
				return 1;
			}
		}
		public static int GL_SRC_COLOR
		{
			get
			{
				return 768;
			}
		}
		public static int GL_ONE_MINUS_SRC_COLOR
		{
			get
			{
				return 769;
			}
		}
		public static int GL_SRC_ALPHA
		{
			get
			{
				return 770;
			}
		}
		public static int GL_ONE_MINUS_SRC_ALPHA
		{
			get
			{
				return 771;
			}
		}
		public static int GL_DST_ALPHA
		{
			get
			{
				return 772;
			}
		}
		public static int GL_ONE_MINUS_DST_ALPHA
		{
			get
			{
				return 773;
			}
		}
		public static int GL_DST_COLOR
		{
			get
			{
				return 774;
			}
		}
		public static int GL_ONE_MINUS_DST_COLOR
		{
			get
			{
				return 775;
			}
		}
		public static int GL_SRC_ALPHA_SATURATE
		{
			get
			{
				return 776;
			}
		}
		public static int GL_FUNC_ADD
		{
			get
			{
				return 32774;
			}
		}
		public static int GL_BLEND_EQUATION
		{
			get
			{
				return 32777;
			}
		}
		public static int GL_BLEND_EQUATION_RGB
		{
			get
			{
				return 32777;
			}
		}
		public static int GL_BLEND_EQUATION_ALPHA
		{
			get
			{
				return 34877;
			}
		}
		public static int GL_FUNC_SUBTRACT
		{
			get
			{
				return 32778;
			}
		}
		public static int GL_FUNC_REVERSE_SUBTRACT
		{
			get
			{
				return 32779;
			}
		}
		public static int GL_BLEND_DST_RGB
		{
			get
			{
				return 32968;
			}
		}
		public static int GL_BLEND_SRC_RGB
		{
			get
			{
				return 32969;
			}
		}
		public static int GL_BLEND_DST_ALPHA
		{
			get
			{
				return 32970;
			}
		}
		public static int GL_BLEND_SRC_ALPHA
		{
			get
			{
				return 32971;
			}
		}
		public static int GL_CONSTANT_COLOR
		{
			get
			{
				return 32769;
			}
		}
		public static int GL_ONE_MINUS_CONSTANT_COLOR
		{
			get
			{
				return 32770;
			}
		}
		public static int GL_CONSTANT_ALPHA
		{
			get
			{
				return 32771;
			}
		}
		public static int GL_ONE_MINUS_CONSTANT_ALPHA
		{
			get
			{
				return 32772;
			}
		}
		public static int GL_BLEND_COLOR
		{
			get
			{
				return 32773;
			}
		}
		public static int GL_ARRAY_BUFFER
		{
			get
			{
				return 34962;
			}
		}
		public static int GL_ELEMENT_ARRAY_BUFFER
		{
			get
			{
				return 34963;
			}
		}
		public static int GL_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34964;
			}
		}
		public static int GL_ELEMENT_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34965;
			}
		}
		public static int GL_STREAM_DRAW
		{
			get
			{
				return 35040;
			}
		}
		public static int GL_STATIC_DRAW
		{
			get
			{
				return 35044;
			}
		}
		public static int GL_DYNAMIC_DRAW
		{
			get
			{
				return 35048;
			}
		}
		public static int GL_BUFFER_SIZE
		{
			get
			{
				return 34660;
			}
		}
		public static int GL_BUFFER_USAGE
		{
			get
			{
				return 34661;
			}
		}
		public static int GL_CURRENT_VERTEX_ATTRIB
		{
			get
			{
				return 34342;
			}
		}
		public static int GL_FRONT
		{
			get
			{
				return 1028;
			}
		}
		public static int GL_BACK
		{
			get
			{
				return 1029;
			}
		}
		public static int GL_FRONT_AND_BACK
		{
			get
			{
				return 1032;
			}
		}
		public static int GL_TEXTURE_2D
		{
			get
			{
				return 3553;
			}
		}
		public static int GL_CULL_FACE
		{
			get
			{
				return 2884;
			}
		}
		public static int GL_BLEND
		{
			get
			{
				return 3042;
			}
		}
		public static int GL_DITHER
		{
			get
			{
				return 3024;
			}
		}
		public static int GL_STENCIL_TEST
		{
			get
			{
				return 2960;
			}
		}
		public static int GL_DEPTH_TEST
		{
			get
			{
				return 2929;
			}
		}
		public static int GL_SCISSOR_TEST
		{
			get
			{
				return 3089;
			}
		}
		public static int GL_POLYGON_OFFSET_FILL
		{
			get
			{
				return 32823;
			}
		}
		public static int GL_SAMPLE_ALPHA_TO_COVERAGE
		{
			get
			{
				return 32926;
			}
		}
		public static int GL_SAMPLE_COVERAGE
		{
			get
			{
				return 32928;
			}
		}
		public static int GL_NO_ERROR
		{
			get
			{
				return 0;
			}
		}
		public static int GL_INVALID_ENUM
		{
			get
			{
				return 1280;
			}
		}
		public static int GL_INVALID_VALUE
		{
			get
			{
				return 1281;
			}
		}
		public static int GL_INVALID_OPERATION
		{
			get
			{
				return 1282;
			}
		}
		public static int GL_OUT_OF_MEMORY
		{
			get
			{
				return 1285;
			}
		}
		public static int GL_CW
		{
			get
			{
				return 2304;
			}
		}
		public static int GL_CCW
		{
			get
			{
				return 2305;
			}
		}
		public static int GL_LINE_WIDTH
		{
			get
			{
				return 2849;
			}
		}
		public static int GL_ALIASED_POINT_SIZE_RANGE
		{
			get
			{
				return 33901;
			}
		}
		public static int GL_ALIASED_LINE_WIDTH_RANGE
		{
			get
			{
				return 33902;
			}
		}
		public static int GL_CULL_FACE_MODE
		{
			get
			{
				return 2885;
			}
		}
		public static int GL_FRONT_FACE
		{
			get
			{
				return 2886;
			}
		}
		public static int GL_DEPTH_RANGE
		{
			get
			{
				return 2928;
			}
		}
		public static int GL_DEPTH_WRITEMASK
		{
			get
			{
				return 2930;
			}
		}
		public static int GL_DEPTH_CLEAR_VALUE
		{
			get
			{
				return 2931;
			}
		}
		public static int GL_DEPTH_FUNC
		{
			get
			{
				return 2932;
			}
		}
		public static int GL_STENCIL_CLEAR_VALUE
		{
			get
			{
				return 2961;
			}
		}
		public static int GL_STENCIL_FUNC
		{
			get
			{
				return 2962;
			}
		}
		public static int GL_STENCIL_FAIL
		{
			get
			{
				return 2964;
			}
		}
		public static int GL_STENCIL_PASS_DEPTH_FAIL
		{
			get
			{
				return 2965;
			}
		}
		public static int GL_STENCIL_PASS_DEPTH_PASS
		{
			get
			{
				return 2966;
			}
		}
		public static int GL_STENCIL_REF
		{
			get
			{
				return 2967;
			}
		}
		public static int GL_STENCIL_VALUE_MASK
		{
			get
			{
				return 2963;
			}
		}
		public static int GL_STENCIL_WRITEMASK
		{
			get
			{
				return 2968;
			}
		}
		public static int GL_STENCIL_BACK_FUNC
		{
			get
			{
				return 34816;
			}
		}
		public static int GL_STENCIL_BACK_FAIL
		{
			get
			{
				return 34817;
			}
		}
		public static int GL_STENCIL_BACK_PASS_DEPTH_FAIL
		{
			get
			{
				return 34818;
			}
		}
		public static int GL_STENCIL_BACK_PASS_DEPTH_PASS
		{
			get
			{
				return 34819;
			}
		}
		public static int GL_STENCIL_BACK_REF
		{
			get
			{
				return 36003;
			}
		}
		public static int GL_STENCIL_BACK_VALUE_MASK
		{
			get
			{
				return 36004;
			}
		}
		public static int GL_STENCIL_BACK_WRITEMASK
		{
			get
			{
				return 36005;
			}
		}
		public static int GL_VIEWPORT
		{
			get
			{
				return 2978;
			}
		}
		public static int GL_SCISSOR_BOX
		{
			get
			{
				return 3088;
			}
		}
		public static int GL_COLOR_CLEAR_VALUE
		{
			get
			{
				return 3106;
			}
		}
		public static int GL_COLOR_WRITEMASK
		{
			get
			{
				return 3107;
			}
		}
		public static int GL_UNPACK_ALIGNMENT
		{
			get
			{
				return 3317;
			}
		}
		public static int GL_PACK_ALIGNMENT
		{
			get
			{
				return 3333;
			}
		}
		public static int GL_MAX_TEXTURE_SIZE
		{
			get
			{
				return 3379;
			}
		}
		public static int GL_MAX_VIEWPORT_DIMS
		{
			get
			{
				return 3386;
			}
		}
		public static int GL_SUBPIXEL_BITS
		{
			get
			{
				return 3408;
			}
		}
		public static int GL_RED_BITS
		{
			get
			{
				return 3410;
			}
		}
		public static int GL_GREEN_BITS
		{
			get
			{
				return 3411;
			}
		}
		public static int GL_BLUE_BITS
		{
			get
			{
				return 3412;
			}
		}
		public static int GL_ALPHA_BITS
		{
			get
			{
				return 3413;
			}
		}
		public static int GL_DEPTH_BITS
		{
			get
			{
				return 3414;
			}
		}
		public static int GL_STENCIL_BITS
		{
			get
			{
				return 3415;
			}
		}
		public static int GL_POLYGON_OFFSET_UNITS
		{
			get
			{
				return 10752;
			}
		}
		public static int GL_POLYGON_OFFSET_FACTOR
		{
			get
			{
				return 32824;
			}
		}
		public static int GL_TEXTURE_BINDING_2D
		{
			get
			{
				return 32873;
			}
		}
		public static int GL_SAMPLE_BUFFERS
		{
			get
			{
				return 32936;
			}
		}
		public static int GL_SAMPLES
		{
			get
			{
				return 32937;
			}
		}
		public static int GL_SAMPLE_COVERAGE_VALUE
		{
			get
			{
				return 32938;
			}
		}
		public static int GL_SAMPLE_COVERAGE_INVERT
		{
			get
			{
				return 32939;
			}
		}
		public static int GL_NUM_COMPRESSED_TEXTURE_FORMATS
		{
			get
			{
				return 34466;
			}
		}
		public static int GL_COMPRESSED_TEXTURE_FORMATS
		{
			get
			{
				return 34467;
			}
		}
		public static int GL_DONT_CARE
		{
			get
			{
				return 4352;
			}
		}
		public static int GL_FASTEST
		{
			get
			{
				return 4353;
			}
		}
		public static int GL_NICEST
		{
			get
			{
				return 4354;
			}
		}
		public static int GL_GENERATE_MIPMAP_HINT
		{
			get
			{
				return 33170;
			}
		}
		public static int GL_BYTE
		{
			get
			{
				return 5120;
			}
		}
		public static int GL_UNSIGNED_BYTE
		{
			get
			{
				return 5121;
			}
		}
		public static int GL_SHORT
		{
			get
			{
				return 5122;
			}
		}
		public static int GL_UNSIGNED_SHORT
		{
			get
			{
				return 5123;
			}
		}
		public static int GL_INT
		{
			get
			{
				return 5124;
			}
		}
		public static int GL_UNSIGNED_INT
		{
			get
			{
				return 5125;
			}
		}
		public static int GL_FLOAT
		{
			get
			{
				return 5126;
			}
		}
		public static int GL_FIXED
		{
			get
			{
				return 5132;
			}
		}
		public static int GL_DEPTH_COMPONENT
		{
			get
			{
				return 6402;
			}
		}
		public static int GL_ALPHA
		{
			get
			{
				return 6406;
			}
		}
		public static int GL_RGB
		{
			get
			{
				return 6407;
			}
		}
		public static int GL_RGBA
		{
			get
			{
				return 6408;
			}
		}
		public static int GL_LUMINANCE
		{
			get
			{
				return 6409;
			}
		}
		public static int GL_LUMINANCE_ALPHA
		{
			get
			{
				return 6410;
			}
		}
		public static int GL_UNSIGNED_SHORT_4_4_4_4
		{
			get
			{
				return 32819;
			}
		}
		public static int GL_UNSIGNED_SHORT_5_5_5_1
		{
			get
			{
				return 32820;
			}
		}
		public static int GL_UNSIGNED_SHORT_5_6_5
		{
			get
			{
				return 33635;
			}
		}
		public static int GL_FRAGMENT_SHADER
		{
			get
			{
				return 35632;
			}
		}
		public static int GL_VERTEX_SHADER
		{
			get
			{
				return 35633;
			}
		}
		public static int GL_MAX_VERTEX_ATTRIBS
		{
			get
			{
				return 34921;
			}
		}
		public static int GL_MAX_VERTEX_UNIFORM_VECTORS
		{
			get
			{
				return 36347;
			}
		}
		public static int GL_MAX_VARYING_VECTORS
		{
			get
			{
				return 36348;
			}
		}
		public static int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS
		{
			get
			{
				return 35661;
			}
		}
		public static int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS
		{
			get
			{
				return 35660;
			}
		}
		public static int GL_MAX_TEXTURE_IMAGE_UNITS
		{
			get
			{
				return 34930;
			}
		}
		public static int GL_MAX_FRAGMENT_UNIFORM_VECTORS
		{
			get
			{
				return 36349;
			}
		}
		public static int GL_SHADER_TYPE
		{
			get
			{
				return 35663;
			}
		}
		public static int GL_DELETE_STATUS
		{
			get
			{
				return 35712;
			}
		}
		public static int GL_LINK_STATUS
		{
			get
			{
				return 35714;
			}
		}
		public static int GL_VALIDATE_STATUS
		{
			get
			{
				return 35715;
			}
		}
		public static int GL_ATTACHED_SHADERS
		{
			get
			{
				return 35717;
			}
		}
		public static int GL_ACTIVE_UNIFORMS
		{
			get
			{
				return 35718;
			}
		}
		public static int GL_ACTIVE_UNIFORM_MAX_LENGTH
		{
			get
			{
				return 35719;
			}
		}
		public static int GL_ACTIVE_ATTRIBUTES
		{
			get
			{
				return 35721;
			}
		}
		public static int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH
		{
			get
			{
				return 35722;
			}
		}
		public static int GL_SHADING_LANGUAGE_VERSION
		{
			get
			{
				return 35724;
			}
		}
		public static int GL_CURRENT_PROGRAM
		{
			get
			{
				return 35725;
			}
		}
		public static int GL_NEVER
		{
			get
			{
				return 512;
			}
		}
		public static int GL_LESS
		{
			get
			{
				return 513;
			}
		}
		public static int GL_EQUAL
		{
			get
			{
				return 514;
			}
		}
		public static int GL_LEQUAL
		{
			get
			{
				return 515;
			}
		}
		public static int GL_GREATER
		{
			get
			{
				return 516;
			}
		}
		public static int GL_NOTEQUAL
		{
			get
			{
				return 517;
			}
		}
		public static int GL_GEQUAL
		{
			get
			{
				return 518;
			}
		}
		public static int GL_ALWAYS
		{
			get
			{
				return 519;
			}
		}
		public static int GL_KEEP
		{
			get
			{
				return 7680;
			}
		}
		public static int GL_REPLACE
		{
			get
			{
				return 7681;
			}
		}
		public static int GL_INCR
		{
			get
			{
				return 7682;
			}
		}
		public static int GL_DECR
		{
			get
			{
				return 7683;
			}
		}
		public static int GL_INVERT
		{
			get
			{
				return 5386;
			}
		}
		public static int GL_INCR_WRAP
		{
			get
			{
				return 34055;
			}
		}
		public static int GL_DECR_WRAP
		{
			get
			{
				return 34056;
			}
		}
		public static int GL_VENDOR
		{
			get
			{
				return 7936;
			}
		}
		public static int GL_RENDERER
		{
			get
			{
				return 7937;
			}
		}
		public static int GL_VERSION
		{
			get
			{
				return 7938;
			}
		}
		public static int GL_EXTENSIONS
		{
			get
			{
				return 7939;
			}
		}
		public static int GL_NEAREST
		{
			get
			{
				return 9728;
			}
		}
		public static int GL_LINEAR
		{
			get
			{
				return 9729;
			}
		}
		public static int GL_NEAREST_MIPMAP_NEAREST
		{
			get
			{
				return 9984;
			}
		}
		public static int GL_LINEAR_MIPMAP_NEAREST
		{
			get
			{
				return 9985;
			}
		}
		public static int GL_NEAREST_MIPMAP_LINEAR
		{
			get
			{
				return 9986;
			}
		}
		public static int GL_LINEAR_MIPMAP_LINEAR
		{
			get
			{
				return 9987;
			}
		}
		public static int GL_TEXTURE_MAG_FILTER
		{
			get
			{
				return 10240;
			}
		}
		public static int GL_TEXTURE_MIN_FILTER
		{
			get
			{
				return 10241;
			}
		}
		public static int GL_TEXTURE_WRAP_S
		{
			get
			{
				return 10242;
			}
		}
		public static int GL_TEXTURE_WRAP_T
		{
			get
			{
				return 10243;
			}
		}
		public static int GL_TEXTURE
		{
			get
			{
				return 5890;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP
		{
			get
			{
				return 34067;
			}
		}
		public static int GL_TEXTURE_BINDING_CUBE_MAP
		{
			get
			{
				return 34068;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_POSITIVE_X
		{
			get
			{
				return 34069;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_NEGATIVE_X
		{
			get
			{
				return 34070;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_POSITIVE_Y
		{
			get
			{
				return 34071;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y
		{
			get
			{
				return 34072;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_POSITIVE_Z
		{
			get
			{
				return 34073;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z
		{
			get
			{
				return 34074;
			}
		}
		public static int GL_MAX_CUBE_MAP_TEXTURE_SIZE
		{
			get
			{
				return 34076;
			}
		}
		public static int GL_TEXTURE0
		{
			get
			{
				return 33984;
			}
		}
		public static int GL_TEXTURE1
		{
			get
			{
				return 33985;
			}
		}
		public static int GL_TEXTURE2
		{
			get
			{
				return 33986;
			}
		}
		public static int GL_TEXTURE3
		{
			get
			{
				return 33987;
			}
		}
		public static int GL_TEXTURE4
		{
			get
			{
				return 33988;
			}
		}
		public static int GL_TEXTURE5
		{
			get
			{
				return 33989;
			}
		}
		public static int GL_TEXTURE6
		{
			get
			{
				return 33990;
			}
		}
		public static int GL_TEXTURE7
		{
			get
			{
				return 33991;
			}
		}
		public static int GL_TEXTURE8
		{
			get
			{
				return 33992;
			}
		}
		public static int GL_TEXTURE9
		{
			get
			{
				return 33993;
			}
		}
		public static int GL_TEXTURE10
		{
			get
			{
				return 33994;
			}
		}
		public static int GL_TEXTURE11
		{
			get
			{
				return 33995;
			}
		}
		public static int GL_TEXTURE12
		{
			get
			{
				return 33996;
			}
		}
		public static int GL_TEXTURE13
		{
			get
			{
				return 33997;
			}
		}
		public static int GL_TEXTURE14
		{
			get
			{
				return 33998;
			}
		}
		public static int GL_TEXTURE15
		{
			get
			{
				return 33999;
			}
		}
		public static int GL_TEXTURE16
		{
			get
			{
				return 34000;
			}
		}
		public static int GL_TEXTURE17
		{
			get
			{
				return 34001;
			}
		}
		public static int GL_TEXTURE18
		{
			get
			{
				return 34002;
			}
		}
		public static int GL_TEXTURE19
		{
			get
			{
				return 34003;
			}
		}
		public static int GL_TEXTURE20
		{
			get
			{
				return 34004;
			}
		}
		public static int GL_TEXTURE21
		{
			get
			{
				return 34005;
			}
		}
		public static int GL_TEXTURE22
		{
			get
			{
				return 34006;
			}
		}
		public static int GL_TEXTURE23
		{
			get
			{
				return 34007;
			}
		}
		public static int GL_TEXTURE24
		{
			get
			{
				return 34008;
			}
		}
		public static int GL_TEXTURE25
		{
			get
			{
				return 34009;
			}
		}
		public static int GL_TEXTURE26
		{
			get
			{
				return 34010;
			}
		}
		public static int GL_TEXTURE27
		{
			get
			{
				return 34011;
			}
		}
		public static int GL_TEXTURE28
		{
			get
			{
				return 34012;
			}
		}
		public static int GL_TEXTURE29
		{
			get
			{
				return 34013;
			}
		}
		public static int GL_TEXTURE30
		{
			get
			{
				return 34014;
			}
		}
		public static int GL_TEXTURE31
		{
			get
			{
				return 34015;
			}
		}
		public static int GL_REPEAT
		{
			get
			{
				return 10497;
			}
		}
		public static int GL_CLAMP_TO_EDGE
		{
			get
			{
				return 33071;
			}
		}
		public static int GL_MIRRORED_REPEAT
		{
			get
			{
				return 33648;
			}
		}
		public static int GL_FLOAT_VEC2
		{
			get
			{
				return 35664;
			}
		}
		public static int GL_FLOAT_VEC3
		{
			get
			{
				return 35665;
			}
		}
		public static int GL_FLOAT_VEC4
		{
			get
			{
				return 35666;
			}
		}
		public static int GL_INT_VEC2
		{
			get
			{
				return 35667;
			}
		}
		public static int GL_INT_VEC3
		{
			get
			{
				return 35668;
			}
		}
		public static int GL_INT_VEC4
		{
			get
			{
				return 35669;
			}
		}
		public static int GL_BOOL
		{
			get
			{
				return 35670;
			}
		}
		public static int GL_BOOL_VEC2
		{
			get
			{
				return 35671;
			}
		}
		public static int GL_BOOL_VEC3
		{
			get
			{
				return 35672;
			}
		}
		public static int GL_BOOL_VEC4
		{
			get
			{
				return 35673;
			}
		}
		public static int GL_FLOAT_MAT2
		{
			get
			{
				return 35674;
			}
		}
		public static int GL_FLOAT_MAT3
		{
			get
			{
				return 35675;
			}
		}
		public static int GL_FLOAT_MAT4
		{
			get
			{
				return 35676;
			}
		}
		public static int GL_SAMPLER_2D
		{
			get
			{
				return 35678;
			}
		}
		public static int GL_SAMPLER_CUBE
		{
			get
			{
				return 35680;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_ENABLED
		{
			get
			{
				return 34338;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_SIZE
		{
			get
			{
				return 34339;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_STRIDE
		{
			get
			{
				return 34340;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_TYPE
		{
			get
			{
				return 34341;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED
		{
			get
			{
				return 34922;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_POINTER
		{
			get
			{
				return 34373;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34975;
			}
		}
		public static int GL_IMPLEMENTATION_COLOR_READ_TYPE
		{
			get
			{
				return 35738;
			}
		}
		public static int GL_IMPLEMENTATION_COLOR_READ_FORMAT
		{
			get
			{
				return 35739;
			}
		}
		public static int GL_COMPILE_STATUS
		{
			get
			{
				return 35713;
			}
		}
		public static int GL_INFO_LOG_LENGTH
		{
			get
			{
				return 35716;
			}
		}
		public static int GL_SHADER_SOURCE_LENGTH
		{
			get
			{
				return 35720;
			}
		}
		public static int GL_SHADER_COMPILER
		{
			get
			{
				return 36346;
			}
		}
		public static int GL_SHADER_BINARY_FORMATS
		{
			get
			{
				return 36344;
			}
		}
		public static int GL_NUM_SHADER_BINARY_FORMATS
		{
			get
			{
				return 36345;
			}
		}
		public static int GL_LOW_FLOAT
		{
			get
			{
				return 36336;
			}
		}
		public static int GL_MEDIUM_FLOAT
		{
			get
			{
				return 36337;
			}
		}
		public static int GL_HIGH_FLOAT
		{
			get
			{
				return 36338;
			}
		}
		public static int GL_LOW_INT
		{
			get
			{
				return 36339;
			}
		}
		public static int GL_MEDIUM_INT
		{
			get
			{
				return 36340;
			}
		}
		public static int GL_HIGH_INT
		{
			get
			{
				return 36341;
			}
		}
		public static int GL_FRAMEBUFFER
		{
			get
			{
				return 36160;
			}
		}
		public static int GL_RENDERBUFFER
		{
			get
			{
				return 36161;
			}
		}
		public static int GL_RGBA4
		{
			get
			{
				return 32854;
			}
		}
		public static int GL_RGB5_A1
		{
			get
			{
				return 32855;
			}
		}
		public static int GL_RGB565
		{
			get
			{
				return 36194;
			}
		}
		public static int GL_DEPTH_COMPONENT16
		{
			get
			{
				return 33189;
			}
		}
		public static int GL_STENCIL_INDEX
		{
			get
			{
				return 6401;
			}
		}
		public static int GL_STENCIL_INDEX8
		{
			get
			{
				return 36168;
			}
		}
		public static int GL_RENDERBUFFER_WIDTH
		{
			get
			{
				return 36162;
			}
		}
		public static int GL_RENDERBUFFER_HEIGHT
		{
			get
			{
				return 36163;
			}
		}
		public static int GL_RENDERBUFFER_INTERNAL_FORMAT
		{
			get
			{
				return 36164;
			}
		}
		public static int GL_RENDERBUFFER_RED_SIZE
		{
			get
			{
				return 36176;
			}
		}
		public static int GL_RENDERBUFFER_GREEN_SIZE
		{
			get
			{
				return 36177;
			}
		}
		public static int GL_RENDERBUFFER_BLUE_SIZE
		{
			get
			{
				return 36178;
			}
		}
		public static int GL_RENDERBUFFER_ALPHA_SIZE
		{
			get
			{
				return 36179;
			}
		}
		public static int GL_RENDERBUFFER_DEPTH_SIZE
		{
			get
			{
				return 36180;
			}
		}
		public static int GL_RENDERBUFFER_STENCIL_SIZE
		{
			get
			{
				return 36181;
			}
		}
		public static int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE
		{
			get
			{
				return 36048;
			}
		}
		public static int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME
		{
			get
			{
				return 36049;
			}
		}
		public static int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL
		{
			get
			{
				return 36050;
			}
		}
		public static int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE
		{
			get
			{
				return 36051;
			}
		}
		public static int GL_COLOR_ATTACHMENT0
		{
			get
			{
				return 36064;
			}
		}
		public static int GL_DEPTH_ATTACHMENT
		{
			get
			{
				return 36096;
			}
		}
		public static int GL_STENCIL_ATTACHMENT
		{
			get
			{
				return 36128;
			}
		}
		public static int GL_NONE
		{
			get
			{
				return 0;
			}
		}
		public static int GL_FRAMEBUFFER_COMPLETE
		{
			get
			{
				return 36053;
			}
		}
		public static int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT
		{
			get
			{
				return 36054;
			}
		}
		public static int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT
		{
			get
			{
				return 36055;
			}
		}
		public static int GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS
		{
			get
			{
				return 36057;
			}
		}
		public static int GL_FRAMEBUFFER_UNSUPPORTED
		{
			get
			{
				return 36061;
			}
		}
		public static int GL_FRAMEBUFFER_BINDING
		{
			get
			{
				return 36006;
			}
		}
		public static int GL_RENDERBUFFER_BINDING
		{
			get
			{
				return 36007;
			}
		}
		public static int GL_MAX_RENDERBUFFER_SIZE
		{
			get
			{
				return 34024;
			}
		}
		public static int GL_INVALID_FRAMEBUFFER_OPERATION
		{
			get
			{
				return 1286;
			}
		}
		static GLES20()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLES20.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLES20"));
		}
		internal static void InitJNI()
		{
		}
	}
}