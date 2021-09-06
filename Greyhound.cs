using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game_EX
{
    public class Greyhound
    {
        public int StartingPosition; //개 사진 시작 위치
        public int RacetrackLength; //경주 트랙 길이
        public PictureBox MyPictureBox = null; //개 사진 객체
        public int Location = 0; //경주 트랙 위치
        public Random Randomizer; //랜덤 객체

        // 한 칸, 두 칸, 세 칸, 네 칸을 무작위적으로 전진
        // 폼에서 PictureBox의 위치를 갱신
        // 경주에서 우승한 경우에는 true를 반환
        public bool Run()
        {
            int nRand;
            nRand = Randomizer.Next(4) + 1;
            Point p = MyPictureBox.Location;
            p.X += nRand;
            MyPictureBox.Location = p;

            Location = p.X;

            //강아지 시작 왼쪽 하단 점은 59 
            //랙 총 사이즈 가로 1190, 강아지 도착 위치 1071 
            if (Location >= (StartingPosition + RacetrackLength)) 
                return true;
            else
                return false;
        }
        //게임 종료 후 초기 값으로 돌아오기
        public void TakeStartingPosition()
        {
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }
    }
}
