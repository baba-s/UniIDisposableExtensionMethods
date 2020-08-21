# UniIDisposableExtensionMethods

IDisposable 型の拡張メソッド

## DisposeIfNotNull

```cs
using Kogane;
using System;
using UnityEngine;

public class TestDisposable : IDisposable
{
    public void Dispose()
    {
    }
}

public class Example : MonoBehaviour
{
    private void Awake()
    {
        var obj = new TestDisposable();

        obj.DisposeIfNotNull();

        // 下記のコードと同様
        // obj?.Dispose();
    }
}
```
