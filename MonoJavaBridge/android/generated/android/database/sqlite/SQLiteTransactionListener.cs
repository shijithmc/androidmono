namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.sqlite.SQLiteTransactionListener_))]
	public partial interface SQLiteTransactionListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onBegin();
		void onCommit();
		void onRollback();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteTransactionListener))]
	internal sealed partial class SQLiteTransactionListener_ : java.lang.Object, SQLiteTransactionListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLiteTransactionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onBegin4861;
		void android.database.sqlite.SQLiteTransactionListener.onBegin()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteTransactionListener_.staticClass, "onBegin", "()V", ref global::android.database.sqlite.SQLiteTransactionListener_._onBegin4861);
		}
		internal static global::MonoJavaBridge.MethodId _onCommit4862;
		void android.database.sqlite.SQLiteTransactionListener.onCommit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteTransactionListener_.staticClass, "onCommit", "()V", ref global::android.database.sqlite.SQLiteTransactionListener_._onCommit4862);
		}
		internal static global::MonoJavaBridge.MethodId _onRollback4863;
		void android.database.sqlite.SQLiteTransactionListener.onRollback()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteTransactionListener_.staticClass, "onRollback", "()V", ref global::android.database.sqlite.SQLiteTransactionListener_._onRollback4863);
		}
		static SQLiteTransactionListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteTransactionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteTransactionListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}