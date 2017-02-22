//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DictionaryComponent dictionary { get { return (DictionaryComponent)GetComponent(GameComponentsLookup.Dictionary); } }
    public bool hasDictionary { get { return HasComponent(GameComponentsLookup.Dictionary); } }

    public void AddDictionary(System.Collections.Generic.Dictionary<string, string> newDict) {
        var component = CreateComponent<DictionaryComponent>(GameComponentsLookup.Dictionary);
        component.dict = newDict;
        AddComponent(GameComponentsLookup.Dictionary, component);
    }

    public void ReplaceDictionary(System.Collections.Generic.Dictionary<string, string> newDict) {
        var component = CreateComponent<DictionaryComponent>(GameComponentsLookup.Dictionary);
        component.dict = newDict;
        ReplaceComponent(GameComponentsLookup.Dictionary, component);
    }

    public void RemoveDictionary() {
        RemoveComponent(GameComponentsLookup.Dictionary);
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

    static Entitas.IMatcher<GameEntity> _matcherDictionary;

    public static Entitas.IMatcher<GameEntity> Dictionary {
        get {
            if(_matcherDictionary == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Dictionary);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDictionary = matcher;
            }

            return _matcherDictionary;
        }
    }
}
