using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_EX
{
    public partial class Form1 : Form
    {
        //게이머 배열 3
        Guy[] guys = new Guy[3];

        //강아지 배열 4
        Greyhound[] dogs = new Greyhound[4];

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            //각 참가자 내용 초기화
            guys[0] = new Guy() { Name = "Joe", Cash = 50, MyRadioButton = this.rdo_Joe, MyLabel = this.lbl_Joe, MyBet = null };
            guys[1] = new Guy() { Name = "Bob", Cash = 75, MyRadioButton = this.rdo_Bob, MyLabel = this.lbl_Bob, MyBet = null };
            guys[2] = new Guy() { Name = "Al", Cash = 45, MyRadioButton = this.rdo_Al, MyLabel = this.lbl_Al, MyBet = null };

            //강아지 시작 위치는 오른쪽 윗 점 위치가  42, 21  사이즈 131, 38  즉, 사진의 왼쪽 하단 점은 59 
            //랙 총 사이즈 가로 1190, 강아지 도착 위치 1071 
            dogs[0] = new Greyhound() { MyPictureBox = this.dog1, StartingPosition = 59, RacetrackLength = 900, Randomizer = rand };
            dogs[1] = new Greyhound() { MyPictureBox = this.dog2, StartingPosition = 59, RacetrackLength = 900, Randomizer = rand };
            dogs[2] = new Greyhound() { MyPictureBox = this.dog3, StartingPosition = 59, RacetrackLength = 900, Randomizer = rand };
            dogs[3] = new Greyhound() { MyPictureBox = this.dog4, StartingPosition = 59, RacetrackLength = 900, Randomizer = rand };

            //폼 재설정
            ResetForm();
        }

        private void ResetForm()
        {
            //강아지 시작 위치로 이동
            for (int i = 0; i < 4; i++)
            {
                dogs[i].TakeStartingPosition();
            }

            //현금 보유액, 배팅 상황 업데이트
            for (int i = 0; i < 3; i++)
            {
                guys[i].Updatelabels();
            }
        }

        //라디오 버튼 체크 부분
        private void rdo_Name_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdo_Joe.Checked)
                this.lbl_Name.Text = "Joe";
            else if(this.rdo_Bob.Checked)
                this.lbl_Name.Text = "Bob";
            else
                this.lbl_Name.Text = "Al";
        }

        private void btnBets_Click(object sender, EventArgs e)
        {
            if (this.rdo_Joe.Checked)
            {
                if (guys[0].PlaceBet((int)numBucks.Value, (int)numDogs.Value))
                    guys[0].Updatelabels();
                else
                    MessageBox.Show("이미 배팅했거나, 베팅액이 현재 현금 보유액보다 큽니다.");
            }
            else if (this.rdo_Bob.Checked)
            {
                if (guys[1].PlaceBet((int)numBucks.Value, (int)numDogs.Value))
                    guys[1].Updatelabels();
                else
                    MessageBox.Show("이미 배팅했거나, 베팅액이 현재 현금 보유액보다 큽니다.");
            }
            else
            {
                if (guys[2].PlaceBet((int)numBucks.Value, (int)numDogs.Value))
                    guys[2].Updatelabels();
                else
                    MessageBox.Show("이미 배팅했거나, 베팅액이 현재 현금 보유액보다 큽니다.");
            }
        }

        private void btn_Race_Click(object sender, EventArgs e)
        {
            bool winner = false;
            int dogNum = 0;
            //배팅이 다 되었는가 체크
            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyBet == null)
                {
                    MessageBox.Show(guys[i].Name + "야 배팅 안하냐?!!");
                    return;
                }
            }

            //레이스~ 스타~트~
            while (!winner)
            {
                for (dogNum = 0;  dogNum< 4 && winner == false; dogNum++)
                {
                    winner = dogs[dogNum].Run();
                }
                //속도가 넘 빨라서 줄인다~
                System.Threading.Thread.Sleep(10);
            }

            //1등 개 표시
            MessageBox.Show($"{dogNum}번 개가 승리 했다~!!");

            //상금 주기
            for (int i = 0; i < 3; i++)
            {
                guys[i].Collect(dogNum);
            }

            //폼 리셋
            ResetForm();
        }
    }
}
