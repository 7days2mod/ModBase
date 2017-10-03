namespace ModBase
{
  public class API : ModApiAbstract
  {
    public override void CalcChunkColorsDone(Chunk _chunk)
    {
      base.CalcChunkColorsDone(_chunk);
    }

    public override bool ChatMessage(ClientInfo _cInfo, EnumGameMessages _type, string _msg, string _mainName, bool _localizeMain, string _secondaryName, bool _localizeSecondary)
    {
      return base.ChatMessage(_cInfo, _type, _msg, _mainName, _localizeMain, _secondaryName, _localizeSecondary);
    }

    public override void GameAwake()
    {
      base.GameAwake();
    }

    public override void GameShutdown()
    {
      base.GameShutdown();
    }

    public override void GameStartDone()
    {
      base.GameStartDone();
    }

    public override void GameUpdate()
    {
      base.GameUpdate();
    }

    public override void PlayerDisconnected(ClientInfo _cInfo, bool _bShutdown)
    {
      base.PlayerDisconnected(_cInfo, _bShutdown);
    }

    public override void PlayerLogin(ClientInfo _cInfo, string _compatibilityVersion)
    {
      base.PlayerLogin(_cInfo, _compatibilityVersion);
    }

    public override void PlayerSpawnedInWorld(ClientInfo _cInfo, RespawnType _respawnReason, Vector3i _pos)
    {
      base.PlayerSpawnedInWorld(_cInfo, _respawnReason, _pos);
    }

    public override void PlayerSpawning(ClientInfo _cInfo, int _chunkViewDim, PlayerProfile _playerProfile)
    {
      base.PlayerSpawning(_cInfo, _chunkViewDim, _playerProfile);
    }

    public override void SavePlayerData(ClientInfo _cInfo, PlayerDataFile _playerDataFile)
    {
      base.SavePlayerData(_cInfo, _playerDataFile);
    }
  }
}
