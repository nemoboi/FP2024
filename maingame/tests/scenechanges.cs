namespace maingame.tests;

using GdUnit4;
using static GdUnit4.Assertions;

[TestSuite]
public class SceneChanges
{
	
	[TestCase]
	public async void VerifyLevelQuit()
	{
		rootScene = load("res://Levels/Tutorial01.tscn")
		rootSceneInstance = rootScene.instantiate()
		await wait_until(func (): return rootSceneInstance.is_inside_tree(), 5)
		
	}
	
}
