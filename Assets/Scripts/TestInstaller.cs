using UnityEngine;
using Zenject;

public class TestInstaller : MonoInstaller<TestInstaller>
{
    public override void InstallBindings()
	{
		Container.Bind<ITextReader> ().To<TextReader> ().AsSingle ();
	}
}