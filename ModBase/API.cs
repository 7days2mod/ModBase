namespace ModBase
{
  public class API : ModApiAbstract
  {
    public override void CalcChunkColorsDone(Chunk _chunk)
    {
      //runs each time a chunk has it's colors re-calculated. For example this is used to generate the images for allocs game map mod
    }

    public override bool ChatMessage(ClientInfo _cInfo, EnumGameMessages _type, string _msg, string _mainName, bool _localizeMain, string _secondaryName, bool _localizeSecondary)
    {
      //return true to pass the message on to the next mod, or if no other mods then it will output to chat.
      //return false to prevent the message from being passed on or output to chat
      return true;
    }

    public override void GameAwake()
    {
      //runs once when the server is ready for interaction and GameManager.Instance.World is set
    }

    public override void GameShutdown()
    {
      //runs once when the server is about to shut down
    }

    public override void GameStartDone()
    {
      //runs once when the server is ready for players to join
    }

    public override void GameUpdate()
    {
      //runs any time the game executes an update (which is very often).
      //place any tasks that you want to process in the main thread here with an execution rate limiter (such as creating entities via the entity factory)
    }

    public override void PlayerDisconnected(ClientInfo _cInfo, bool _bShutdown)
    {
      //runs on each player disconnect
    }

    public override void PlayerLogin(ClientInfo _cInfo, string _compatibilityVersion)
    {
      //runs on initial connection from a player, _cInfo is usually null at this point
    }

    public override void PlayerSpawnedInWorld(ClientInfo _cInfo, RespawnType _respawnReason, Vector3i _pos)
    {
      //runs each time a player spawns, including on login, respawn from death, and teleport
    }

    public override void PlayerSpawning(ClientInfo _cInfo, int _chunkViewDim, PlayerProfile _playerProfile)
    {
      //runs just before a player is spawned int the world
    }

    public override void SavePlayerData(ClientInfo _cInfo, PlayerDataFile _playerDataFile)
    {
      //runs each time a player file is saved from the client to the server
      //this will usually run about every 30 seconds per player as well as triggered updates such as dying
    }
  }
}
