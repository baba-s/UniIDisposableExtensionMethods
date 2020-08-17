using System;

namespace Kogane
{
	/// <summary>
	/// IDisposable 型の拡張メソッドを管理するクラス
	/// </summary>
	public static class IDisposableExt
	{
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// 指定された IDisposable 型のインスタンスが null ではない場合にのみ Dispose を実行します
		/// </summary>
		public static void DisposeIfNotNull( this IDisposable self )
		{
			self?.Dispose();
		}
	}
}