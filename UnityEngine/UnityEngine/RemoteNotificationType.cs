﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.RemoteNotificationType
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System;

namespace UnityEngine
{
  [Obsolete("RemoteNotificationType is deprecated. Please use iOS.NotificationType instead (UnityUpgradable) -> UnityEngine.iOS.NotificationType", true)]
  public enum RemoteNotificationType
  {
    None,
    Badge,
    Sound,
    Alert,
  }
}