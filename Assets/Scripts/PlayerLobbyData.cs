using Fusion;
using UnityEngine;

public class PlayerLobbyData : NetworkBehaviour
{
    [Networked] public int CharacterIdex { get; set; }
    [Networked] public int TeamIndex { get; set; }
    [Networked] public NetworkBool IsReady { get; set; }

    public override void Spawned()
    {
        if (Object.HasStateAuthority)
        {
            CharacterIdex = 0;
            TeamIndex = 0;
            IsReady = false;
        }

        Debug.Log($"LobbyData Spawned / InputAuthority : {Object.InputAuthority}");
    }

    [Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority)]
    public void RPC_SelectCharacter(int index)
    {
        CharacterIdex = Mathf.Max(0, index);
        IsReady = false;

        Debug.Log($"{Object.InputAuthority}캐릭터 선택: {CharacterIdex}");
    }

    [Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority)]
    public void RPC_SelectTeam(int teamIndex)
    {
        teamIndex = Mathf.Clamp(teamIndex, 0, 1);

        FusionBootstrap bootstrap = FindObjectOfType<FusionBootstrap>();

        /*if (bootstrap != null && !bootstrap.CanJoinTeam(teamIndex))
        {
            return;
        }*/

        TeamIndex = teamIndex;
        IsReady = false;

        Debug.Log($"{Object.InputAuthority} 팀 선택: {teamIndex}");
    }

    [Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority)]
    public void RPC_SetReady(NetworkBool ready)
    {
        IsReady = ready;

        Debug.Log($"{Object.InputAuthority} Ready: {IsReady}");
    }
}
