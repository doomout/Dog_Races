using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_EX
{
    public class Guy
    {
        public string Name; //사람 이름
        public Bet MyBet; //배팅 내역을 저장할 Bet 인스턴스
        public int Cash; //지금 가지고 있는 현금 액수

        public RadioButton MyRadioButton; //라디오 버튼
        public Label MyLabel; //레이블

        public void Updatelabels()
        {
            //RadioButton 에 붙일 Label에는 현재 현금 보유액을 표시
            MyRadioButton.Text = Name + " has " + Cash + " bucks";

            //Label에 배팅내역을 표시하고
            if (MyBet == null)
            {
                MyLabel.Text = Name + "야 배팅 안했다~!!";
            }
            else
            {
                this.MyLabel.Text = MyBet.GetDesciption();
            }
        }
        public void ClearBet()
        {
            MyBet = null;
        }

        //지정한 개에게 배팅하는 함수
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            //배팅 값이 현재 보유금액 보다 크면 false 반환
            if (BetAmount > Cash)
                return false;

            //새로 배팅을 하고 배팅 내역을 MyBet 필드에 저장
            MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this };
            return true;
        }

        //배팅 결과를 처리 하는 부분(MyBet를 초기화 하고, MyLabel을 갱신하는 부분)
        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
        }
    }
}
