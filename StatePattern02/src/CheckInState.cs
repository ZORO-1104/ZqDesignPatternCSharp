using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern02.src
{
    class CheckInState : IRoomState
    {
        private RoomContext _roomContext;
        public CheckInState(RoomContext roomContext)
        {
            _roomContext = roomContext;
        }

        public void BookRoom()
        {
            Console.WriteLine("房间已入住，无法被预订。。。");
        }

        public void CheckInRoom()
        {
            Console.WriteLine("房间已入住，无法被再入住。。。");
        }

        public void CheckOutRoom()
        {
            Console.WriteLine("退房成功。。。");
            _roomContext.State = new FreeTimeState(_roomContext);
        }

        public void UnSubscribeRoom()
        {
            Console.WriteLine("房间已入住，无此取消预订操作。。。");
        }
    }
}
