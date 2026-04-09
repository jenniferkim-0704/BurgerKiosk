namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;

            // 실시간 주문 미리보기 업데이트를 위해 CheckedChanged 이벤트 등록
            rdoHamBurger.CheckedChanged += (s, e) => UpdateOrderPreview();
            rdoBulgogiBurger.CheckedChanged += (s, e) => UpdateOrderPreview();
            rdoChickenBurger.CheckedChanged += (s, e) => UpdateOrderPreview();

            chkPotato.CheckedChanged += (s, e) => UpdateOrderPreview();
            chkCola.CheckedChanged += (s, e) => UpdateOrderPreview();
            chkCheese.CheckedChanged += (s, e) => UpdateOrderPreview();
            chkSauce.CheckedChanged += (s, e) => UpdateOrderPreview();

            // Make Enter trigger the 주문하기 button
            this.AcceptButton = btnOrder;

            // Enter로 라디오 선택 후 옵션으로 포커스 이동하도록 라디오에 KeyDown 핸들러 등록
            rdoHamBurger.KeyDown += Radio_KeyDown;
            rdoBulgogiBurger.KeyDown += Radio_KeyDown;
            rdoChickenBurger.KeyDown += Radio_KeyDown;

            // Let the form handle Tab navigation between GroupBoxes
            this.KeyDown += Form1_KeyDown;

            // Ensure first Tab goes into grpMenu by focusing its first control when form is shown
            this.Shown += Form1_Shown;
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            // 초기에는 아무 컨트롤도 포커스하지 않아서 Tab을 누르면 grpMenu로 들어가도록 함
            this.ActiveControl = null;
        }
        private void Radio_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender is RadioButton rb)
                    rb.Checked = true; // CheckedChanged에서 UpdateOrderPreview가 호출됩니다.

                // 엔터 누르면 옆(옵션)으로 이동: 첫 체크박스로 포커스 이동
                chkPotato.Focus();

                // AcceptButton 동작(주문하기 실행) 방지
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 실제 주문 확정: 현재 미리보기 내용을 그대로 사용
            if (lstOrder.Items.Count == 0)
            {
                lblError.Visible = true;
                return;
            }
        }

        // 선택/체크 상태가 변경될 때 호출되어 리스트와 총액을 즉시 갱신
        private void UpdateOrderPreview()
        {
            lstOrder.Items.Clear();
            int totalCost = 0;

            if (rdoHamBurger.Checked)
            {
                lstOrder.Items.Add("햄버거 5,000원");
                totalCost += 5000;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                lstOrder.Items.Add("불고기버거 4,000원");
                totalCost += 4000;
            }
            else if (rdoChickenBurger.Checked)
            {
                lstOrder.Items.Add("치킨버거 3,000원");
                totalCost += 3000;
            }

            if (chkPotato.Checked)
            {
                lstOrder.Items.Add("감자튀김 3,500원");
                totalCost += 3500;
            }

            if (chkCola.Checked)
            {
                lstOrder.Items.Add("콜라 2,500원");
                totalCost += 2500;
            }

            if (chkCheese.Checked)
            {
                lstOrder.Items.Add("치즈 추가 1,500원");
                totalCost += 1500;
            }

            if (chkSauce.Checked)
            {
                lstOrder.Items.Add("소스 추가 500원");
                totalCost += 500;
            }

            lblTotalCost.Text = "총 금액 : " + totalCost.ToString("N0") + "원";
            lblError.Visible = lstOrder.Items.Count == 0;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
