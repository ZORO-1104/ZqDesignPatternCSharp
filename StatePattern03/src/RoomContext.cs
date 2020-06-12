using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern03.src
{
    class RoomContext
    {
        private IRoomState _state;

        public IRoomState State
        {
            get => _state;
            set => _state = value;
        }

        //private IRoomState _freeTimeState;
        //private IRoomState _bookedState;
        //private IRoomState _checkInState;

        public RoomContext()
        {
            //_freeTimeState = new FreeTimeState(this);
            //_bookedState = new BookedState(this);
            //_checkInState = new CheckInState(this);

            ////初始状态为空房间
            //_state = _freeTimeState;

            _state = new FreeTimeState(); ;
        }


        public void BookRoom()
        {
            _state.BookRoom(this);
        }

        //退订房间
        public void UnSubscribeRoom()
        {
            _state.UnSubscribeRoom(this);
        }

        //入住
        public void CheckInRoom()
        {
            _state.CheckInRoom(this);
        }

        //退房
        public void CheckOutRoom()
        {
            _state.CheckOutRoom(this);
        }

        public string GetState()
        {
            return _state.GetType().Name;
        }
    }
}
