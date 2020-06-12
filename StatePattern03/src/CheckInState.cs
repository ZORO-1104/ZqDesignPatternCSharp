using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern03.src
{
    class CheckInState : IRoomState
    {
        public void BookRoom(RoomContext roomContext)
        {
            Console.WriteLine("房间已入住，无法被预订。。。");
        }

        public void CheckInRoom(RoomContext roomContext)
        {
            Console.WriteLine("房间已入住，无法被再入住。。。");
        }

        public void CheckOutRoom(RoomContext roomContext)
        {
            Console.WriteLine("退房成功。。。");
            roomContext.State = new FreeTimeState();
        }

        public void UnSubscribeRoom(RoomContext roomContext)
        {
            Console.WriteLine("房间已入住，无此取消预订操作。。。");
        }
    }
}
