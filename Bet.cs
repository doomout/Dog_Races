using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_EX
{
    public class Bet
    {
        public int Amount; //배팅한 금액
        public int Dog; //배팅한 개의 번호
        public Guy Bettor; //배팅한 사람에 해당하는 Guy 개체

        public string GetDesciption()
        {
            string temp;
            //배팅 금액이 0이면 배팅을 하지 않았다는 내용의 문자열을 반환
            if (Amount == 0)
            {
                temp = Bettor.Name +  "야 배팅 안했다 ㅡㅡ";
            }
            else
            {
                temp= Bettor.Name + " 가 " + Amount + " $를  " + Dog +" 번 개에게 걸었다.";
            }
            // 누가 얼마큼 어떤 개에게 걸었는지 나타내는 문자열을 반환
            return temp;
        }
        public int PayOut(int Winner)
        {
            //우승한 개의 번호가 매개변수로 전달 됨
            if (Winner == Dog) //배팅한 개가 우승했으면 배팅 액수를 반환
                return Amount;
            else  //우승하지 못하면 배팅 액스에 마이너스를 붙여서 반환
                return -Amount;
        }
    }
}
