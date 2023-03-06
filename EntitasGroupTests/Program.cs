// See https://aka.ms/new-console-template for more information

using Entitas;

Console.WriteLine("Hello, World!");

var entity = Contexts.sharedInstance.game.CreateEntity();
IGroup<GameEntity> group = Contexts.sharedInstance.game.GetGroup(GameMatcher.Parent);
group.OnEntityOnlyAdded += (group1, gameEntity, index, component) => Console.WriteLine("Component added");
group.OnEntityOnlyRemoved += (group1, gameEntity, index, component) => Console.WriteLine("Component removed");
group.OnEntityUpdated += (group1, gameEntity, index, oldComponent, newComponent) => Console.WriteLine("Component updated");
entity.AddParent(1.0f);
entity.ReplaceParent(2.0f);
entity.ReplaceParent(3.0f);
entity.ReplaceParent(0.5f);
entity.RemoveParent();
