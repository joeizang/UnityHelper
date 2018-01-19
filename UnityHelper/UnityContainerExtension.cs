// Decompiled with JetBrains decompiler
// Type: Prism.Unity.UnityContainerExtension
// Assembly: Prism.Unity.Forms, Version=7.0.0.362, Culture=neutral, PublicKeyToken=null
// MVID: 876C8D45-0A2B-4F62-9AD9-243AE6D348F3
// Assembly location: C:\Users\Administrator\.nuget\packages\prism.unity.forms\7.0.0.362\lib\netstandard2.0\Prism.Unity.Forms.dll


using System;
using Unity;
using Unity.Registration;
using Unity.Resolution;

namespace UnityHelper
{
  public class UnityContainerExtension : IContainerExtension<IUnityContainer>, IContainerExtension, IContainerProvider, IContainerRegistry
  {
    public IUnityContainer Instance { get; }

    public bool SupportsModules
    {
      get
      {
        return true;
      }
    }

    public UnityContainerExtension(IUnityContainer container)
    {
      this.Instance = container;
    }

    public void FinalizeExtension()
    {
    }

    public void RegisterInstance(Type type, object instance)
    {
      UnityContainerExtensions.RegisterInstance(this.Instance, type, instance);
    }

    public void RegisterSingleton(Type from, Type to)
    {
      UnityContainerExtensions.RegisterSingleton(this.Instance, from, to, Array.Empty<InjectionMember>());
    }

    public void Register(Type from, Type to)
    {
      UnityContainerExtensions.RegisterType(this.Instance, from, to, Array.Empty<InjectionMember>());
    }

    public void Register(Type from, Type to, string name)
    {
      UnityContainerExtensions.RegisterType(this.Instance, from, to, name, Array.Empty<InjectionMember>());
    }

    public object Resolve(Type type)
    {
      return UnityContainerExtensions.Resolve(this.Instance, type, Array.Empty<ResolverOverride>());
    }

    public object Resolve(Type type, string name)
    {
      return this.Instance.Resolve(type, name, Array.Empty<ResolverOverride>());
    }

    
  }
}
