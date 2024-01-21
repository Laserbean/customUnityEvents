public interface IEvent { }

public struct TestEvent : IEvent { }

public struct PlayerEvent : IEvent
{
    public int health;
    public int mana;
}


// void OnEnable() {    
//     playerEventBinding = new EventBinding<PlayerEvent>(HandlePlayerEvent);
//     EventBus<PlayerEvent>.Register(playerEventBinding);
// }

// void OnDisable() {
//     EventBus<PlayerEvent>.Deregister(playerEventBinding);
// }

// void Start() {
//     EventBus<PlayerEvent>.Raise(new PlayerEvent {
//         health = healthComponent.GetHealth(),
//         mana = manaComponent.GetMana()
//     });    
// }
