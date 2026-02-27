using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Study.Delegate_연습
{
    public partial class Delegate1 : Form
    {
        int _iTotalPrice = 0;
        public delegate int delOrder(int i);

        public Delegate1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //delFuncDow_Edge delDow = new delFuncDow_Edge(fDow);
            delOrder dOrder = null;
            if (rdoDowOriginal.Checked) dOrder += fDowOriginal;
            else if (rdoDowThin.Checked) dOrder += fDowThin;

            if (rdoEdgeGold.Checked) dOrder += fEdgeRichGold;
            else if (rdoEdgeCheese.Checked) dOrder += fEdgeCheese;

            if (cBoxTopping1.Checked) dOrder += fAddSausage;
            if (cBoxTopping2.Checked) dOrder += fAddPotato;
            if (cBoxTopping3.Checked) dOrder += fAddCheese;

            int totalPrice = dOrder(((int)numEa.Value));

            lBoxOder.Items.Add($"최총 결제 가격은 {totalPrice} 입니다.");



        }

        #region Function
        private int fDowOriginal(int i)
        {
            int iPrice = 10000;
            lBoxOder.Items.Add($"[도우] 오리지널 선택 (+{iPrice})");
            return _iTotalPrice += iPrice;
        }

        private int fDowThin(int i)
        {
            int iPrice = 11000;
            lBoxOder.Items.Add($"[도우] 씬 선택 (+{iPrice})");
            return _iTotalPrice += iPrice;
        }

        private int fEdgeRichGold(int i)
        {
            int iPrice = 1000;
            lBoxOder.Items.Add($"[엣지] 리치골드 추가 (+{iPrice})");
            return _iTotalPrice += iPrice;
        }

        private int fEdgeCheese(int i)
        {
            int iPrice = 2000;
            lBoxOder.Items.Add($"[엣지] 치즈크러스트 추가 (+{iPrice})");
            return _iTotalPrice += iPrice;
        }



        private int fAddSausage(int i)
        {
            int iPrice = 500;
            lBoxOder.Items.Add($"[토핑] 소세지 추가 (+{iPrice * i})");
            return _iTotalPrice += (iPrice * i);
        }

        private int fAddPotato(int i)
        {
            int iPrice = 200;
            lBoxOder.Items.Add($"[토핑] 감자 추가 (+{iPrice * i})");
            return _iTotalPrice += (iPrice * i);
        }

        private int fAddCheese(int i)
        {
            int iPrice = 1500;
            lBoxOder.Items.Add($"[토핑] 치즈 추가 (+{iPrice * i})");
            return _iTotalPrice += (iPrice * i);
        }





        #endregion
    }
}
