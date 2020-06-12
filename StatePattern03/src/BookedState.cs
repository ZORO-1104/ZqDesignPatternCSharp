using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern03.src
{
    class BookedState : IRoomState
    {
        public void BookRoom(RoomContext roomContext)
        {
            Console.WriteLine("房间已经被预订，无法再被预订。。。");
        }

        public void CheckInRoom(RoomContext roomContext)
        {
            Console.WriteLine("入住房间成功。。。");
            roomContext.State = new CheckInState();
        }

        public void CheckOutRoom(RoomContext roomContext)
        {
            Console.WriteLine("无此操作。。。");
        }

        public void UnSubscribeRoom(RoomContext roomContext)
        {
            Console.WriteLine("取消预订房间成功。。。");
            roomContext.State = new FreeTimeState();
        }
    }
}
