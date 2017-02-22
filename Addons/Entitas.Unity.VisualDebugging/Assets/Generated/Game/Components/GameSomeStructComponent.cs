//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SomeStructComponent someStruct { get { return (SomeStructComponent)GetComponent(GameComponentsLookup.SomeStruct); } }
    public bool hasSomeStruct { get { return HasComponent(GameComponentsLookup.SomeStruct); } }

    public void AddSomeStruct(SomeStruct newValue) {
        var component = CreateComponent<SomeStructComponent>(GameComponentsLookup.SomeStruct);
        component.value = newValue;
        AddComponent(GameComponentsLookup.SomeStruct, component);
    }

    public void ReplaceSomeStruct(SomeStruct newValue) {
        var component = CreateComponent<SomeStructComponent>(GameComponentsLookup.SomeStruct);
        component.value = newValue;
        ReplaceComponent(GameComponentsLookup.SomeStruct, component);
    }

    public void RemoveSomeStruct() {
        RemoveComponent(GameComponentsLookup.SomeStruct);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSomeStruct;

    public static Entitas.IMatcher<GameEntity> SomeStruct {
        get {
            if(_matcherSomeStruct == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SomeStruct);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSomeStruct = matcher;
            }

            return _matcherSomeStruct;
        }
    }
}
