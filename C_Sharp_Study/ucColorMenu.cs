using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C_Sharp_Study
{
    public partial class ucColorMenu : UserControl
    {
        // 1) Delegate Event 선언
        public delegate void delColorSender(object oSender, Color oColor);
        public event delColorSender eColorSender;

        // 2) 기본 EventHandler
        public event EventHandler oColorEventHandler;

        // 3) 제네릭 형태의 delegate 사용
        public event Action<object, Color> eColorAction;



        public ucColorMenu()
        {
            InitializeComponent();
        }

        private void ucColorMenu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                Button obtn = new Button
                {
                    Name = $"btn{i}",
                    Text = $"P{i} 색상 변경",
                    BackColor = Color.Gray,
                    Margin = new Padding(10, 20, 0, 0),
                    Size = new Size(100, 30),
                    Tag = i // 버튼 식별을 위한 인덱스 저장
                };

                obtn.Click += Obtn_Click;
                flpMenu.Controls.Add(obtn);
            }
        }


        private void Obtn_Click(object sender, EventArgs e)
        {
            //eColorSender(sender, pColor.BackColor);
            //oColorEventHandler(sender, e);
            eColorAction(sender, pColor.BackColor);
        }

        private void pColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dRet = cDialogColor.ShowDialog(); // ColorDialog를 불러서 선택한 뒤 결과 값까지 받아 옴

            if (dRet == DialogResult.OK)    // 결과 값이 정상일 때 선택 된 Color를 Panel에 뿌려줌
            {
                pColor.BackColor = cDialogColor.Color;
            }
        }

    }
}
