namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            chkPotato.KeyDown += chkMenu_KeyDown;
            chkCola.KeyDown += chkMenu_KeyDown;
            chkCheese.KeyDown += chkMenu_KeyDown;
            chkSauce.KeyDown += chkMenu_KeyDown;

            // 라디오 버튼에도 KeyDown 이벤트 핸들러 등록하여 방향키로 선택 가능하도록 설정
            rdoHamBurger.KeyDown += chkMenu_KeyDown;
            rdoBulgogiBurger.KeyDown += chkMenu_KeyDown;
            rdoChickenBurger.KeyDown += chkMenu_KeyDown;

            // Make Enter trigger the 주문하기 button
            this.AcceptButton = btnOrder;

            // Let the form handle Tab navigation between GroupBoxes
            this.KeyDown += Form1_KeyDown;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 메뉴가 선택되지 않은 경우 오류 메시지 표시
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblError.Visible = true;
                return;
            }

            int totalCost = 0; // 총 금액 계산을 위한 변수 초기화

            // 햄버거 종류에 따른 가격 계산
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }

            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }

            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            // 추가 메뉴에 따른 가격 계산
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }

            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }

            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }

            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }
            lblTotalCost.Text = "총 금액 : " + totalCost.ToString("N0") + "원";
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            // 햄버거 종류 라디오 버튼 초기화
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            // 추가 메뉴 체크박스 초기화
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 주문 내역 리스트 초기화
            lstOrder.Items.Clear();

            // 총 금액 초기화
            lblTotalCost.Text = "총 금액 : 0원";
        }
        private void chkMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
                SelectNextControl((Control)sender, true, true, true, true);

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
                SelectNextControl((Control)sender, false, true, true, true);
        }

        // Tab 키로 GroupBox 간 이동 구현
        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
                return;

            // 그룹 박스의 순서대로 이동
            var groups = new Control[] { grpMenu, grpOption, grpOrder };

            // 현재 포커스가 속한 그룹 인덱스 찾기
            Control? focused = this.ActiveControl;
            int currentIndex = -1;

            Control? p = focused;
            while (p != null)
            {
                for (int i = 0; i < groups.Length; i++)
                {
                    if (p == groups[i])
                    {
                        currentIndex = i;
                        break;
                    }
                }
                if (currentIndex != -1)
                    break;
                p = p.Parent;
            }

            int nextIndex;
            if (e.Shift)
                nextIndex = (currentIndex <= 0) ? groups.Length - 1 : currentIndex - 1;
            else
                nextIndex = (currentIndex < 0) ? 0 : (currentIndex + 1) % groups.Length;

            // 대상 그룹의 첫 포커스 가능한 컨트롤로 포커스 이동
            foreach (Control c in groups[nextIndex].Controls)
            {
                if (c.CanFocus && c.TabStop && c.Visible && c.Enabled)
                {
                    c.Focus();
                    e.Handled = true;
                    return;
                }
            }

            // 만약 그룹 내부에 포커스 가능한 컨트롤이 없다면 그룹 자체에 포커스
            groups[nextIndex].Focus();
            e.Handled = true;
        }
    }
}
