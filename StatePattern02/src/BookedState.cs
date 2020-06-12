using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern02.src
{
    class BookedState : IRoomState
    {
        private RoomContext _roomContext;
        public BookedState(RoomContext roomContext)
        {
            _roomContext = roomContext;
        }

        public void BookRoom()
        {
            Console.WriteLine("房间已经被预订，无法再被预订。。。");
        }

        public void CheckInRoom()
        {
            Console.WriteLine("入住房间成功。。。");
            _roomContext.State = new CheckInState(_roomContext);
        }

        public void CheckOutRoom()
        {
            Console.WriteLine("无此操作。。。");
        }

        public void UnSubscribeRoom()
        {
            Console.WriteLine("取消预订房间成功。。。");
            _roomContext.State = new FreeTimeState(_roomContext);
        }
    }
}
