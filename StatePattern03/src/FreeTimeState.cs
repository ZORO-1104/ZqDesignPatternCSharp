using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern03.src
{
    class FreeTimeState : IRoomState
    { 
        public void BookRoom(RoomContext roomContext)
        {
            Console.WriteLine("预订房间成功。。。");
            roomContext.State = new BookedState();
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
            Console.WriteLine("无此操作。。。");
        }
    }
}
