using UnityEditor;
class MyEditorScript
{
    static void PerformBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/NewScene.unity" };
        System.Object value = BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
