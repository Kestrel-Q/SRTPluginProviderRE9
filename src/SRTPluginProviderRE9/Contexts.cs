namespace SRTPluginProviderRE9
{
    public abstract record class CharacterContext
    {
        public HPData HP { get; internal set; }
    }

    public record class PlayerContext : CharacterContext
    {
    }

    public record class EnemyContext : CharacterContext
    {
        public ushort KindID { get; internal set; }
    }
}
