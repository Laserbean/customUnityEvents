# Note
All the files in this folder has been shamelessly stolen (with credit) from https://github.com/adammyhre/Unity-Event-Bus
Honestly not sure if this is better than my event manager class or not. 


    EventBinding<PlayerEvent> playerEventBinding;

    void OnEnable() {    
        playerEventBinding = new EventBinding<PlayerEvent>(HandlePlayerEvent);
        EventBus<PlayerEvent>.Register(playerEventBinding);
    }  

    void OnDisable() {
        EventBus<PlayerEvent>.Deregister(playerEventBinding);
    }  

    void Start() {
        EventBus<PlayerEvent>.Raise(new PlayerEvent {
            health = healthComponent.GetHealth(),
            mana = manaComponent.GetMana()
        });    
    }
