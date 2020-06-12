using System;
using System.Collections.Generic;
using System.Text;

namespace StategyPattern.src
{
    class StrategyContext
    {
        private BaseStrategy _baseStrategy;

        public void SetStrategy(BaseStrategy baseStrategy)
        {
            _baseStrategy = baseStrategy;
        }

        public BaseStrategy GetStrategy()
        {
            return _baseStrategy;
        }

        #region 简单工厂与策略模式的结合
        //public StrategyContext(PersonEnum personEnum)
        //{
        //    _baseStrategy = CreateFactory(personEnum);
        //}

        //private BaseStrategy CreateFactory(PersonEnum personEnum)
        //{
        //    BaseStrategy baseStrategy = null;

        //    switch (personEnum)
        //    {
        //        case PersonEnum.Common:
        //            baseStrategy = new CommonPersonStrategy();
        //            break;
        //        case PersonEnum.Student:
        //            baseStrategy = new StudentStrategy();
        //            break;
        //        case PersonEnum.OldMen:
        //            baseStrategy = new OldPersonStrategy();
        //            break;
        //        default:
        //            baseStrategy = new CommonPersonStrategy();
        //            break;
        //    }

        //    return baseStrategy;
        //}
        #endregion

        public double GetFinalPrice(double price)
        {
            return _baseStrategy.GetTicketPrice(price);
        }
    }
}
