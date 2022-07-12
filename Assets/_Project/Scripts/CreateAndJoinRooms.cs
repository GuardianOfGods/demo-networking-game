using Photon.Pun;
public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public string RoomName = "HoangVanThu";

    public  void CreateRoom()
    {
        PhotonNetwork.CreateRoom(RoomName);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(RoomName);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
