using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX
{
    public partial class index : Form
    {
        string name = ""; //ชื่อผู้ใช้
        double income = 0; //รายได้ต่อปี  //อย่าลืม ลดทันที 60,000 บาท
        int myself = 60000; //ลดหย่อนตนเอง


        //ตนเอง และครอบครัว
        double Spouse = 0; //เก็บค่าลดหย่อนคู่สมรส
        double son_30000 = 0;
        double son_60000 = 0;
        double sum_son = 0; //รวมค่าลดหย่อนลูก
        double father_User = 0; //พ่อแม่ของผู้ใช้
        double mother_User = 0;
        double father_Spouse = 0; //พ่อแม่ของคู่สมรส
        double mother_Spouse = 0;
        double sum_FatherAndMother = 0; //รวมของบิดามารดา
        double womb = 0; //ค่าตั้งครรภ์
        double cripple = 0;//คนพิการ


        //ประกันเงินออม และการลงทุน
        double social_security = 0; //ประกันสังคม
        double life_security = 0; //ประกันชีวิต
        double heal_security = 0; //ประกันสุขภาพ
        double spouse_security = 0; //ประกันคู่สมรส
        double FM_security = 0; //ประกันบิดามารดา
        double provident_fund = 0; //กองทุนสำรองเลี้ยงชีพ
        double KOH = 0; //กอช.
        double teacher_fund = 0; //กองทุนครู
        double pension = 0; //เบี้ยบำนาญ
        double LTF = 0;
        double RMF = 0;


        //อสังหาริมทรัพย์
        double interestHome_value = 0; //ดอกเบี้ยบ้าน
        double buyHomefrist_value = 0; //โครงการบ้านหลังแรก


        //เงินบริจาค
        double donate_to_the_state = 0; //บริจาคให้สาธารณประโยชน์
        double pabuk = 0; //ปาบึก
        double normal_donate = 0; //บริจาคทั่วไป
        double donate_to_political = 0; //ให้พรรคการเมือง

        //กระตุ้นเศรษฐกิจ
        double shop_help_nation = 0; //ช้อปช่วยชาติ
        double shop_sport = 0; //ซื้อของกีฬา
        double shop_book = 0; //หนังสือ
        double repair_home_frompabuk = 0; //ซ่อมบ้านจากปาบึก
        double repair_home_frompodul = 0; //ซ่อมบบ้านจากโพดุล
        double shop_OTOP = 0;
        double travel_main = 0;
        double travel_seconary = 0;
        double repair_car = 0;
        double realty = 0;

        //อื่นๆ 
        double net = 0;
        double vat = 0;
        double sum_tax = 0; //รวมส่วนลดหย่อน
        double allpay = 0;
        string allpay_string = "";
        double group1 = 0;
        double group2 = 0;
        double group3 = 0;
        double group4 = 0;
        double group5 = 0;
        //double special = 0; //ค่ายกเว้น
        


        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void HomeBT_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 268);
            workBar.Size = new Size(8, 60);
            Panelindex.BringToFront();
            
        }

        private void Group1BT_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 327);
            workBar.Size = new Size(8, 60);
            Panel_Group1.BringToFront();
        }

        private void Group2BT_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 386);
            workBar.Size = new Size(8, 77);
            Panel_group2.BringToFront();
        }

        private void Group3BT_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 462);
            workBar.Size = new Size(8, 60);
            Panel_group3.BringToFront();
        }

        private void Group4BT_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 521);
            workBar.Size = new Size(8, 60);
            Panel_group4.BringToFront();
        }

        private void Group5BT_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 580);
            workBar.Size = new Size(8, 60);
            Panel_group5.BringToFront();
        }

        private void Panelindex_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Next_to_family_Click(object sender, EventArgs e)
        {
            if (name == "")
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้ก่อน");
            }
            else
            {
                workBar.Location = new Point(0, 327);
                workBar.Size = new Size(8, 60);
                Panel_Group1.BringToFront();
            }
            
        }

        //ตนเองและครอบครัว---------------------------------------------------------------------------------------------------------------------
        private void status_user_SelectedIndexChanged(object sender, EventArgs e) //เมื่อมีการแก้ไขค่า สถานภาพ
        {
            if (status_user.Text == "มีคู่สมรส แต่คู่สมรสไม่มีรายได้")
            {
                Spouse = 60000;
            }
            else
            {
                Spouse = 0;
            }
        }

        private void No_son_CheckedChanged(object sender, EventArgs e) //ถ้าไม่มีลูก
        {
            if (No_son.Checked == true)
            {
                son_before2561.Checked = false;
                son_before2561.Enabled = false;

                son_after2561.Checked = false;
                son_after2561.Enabled = false;

                son_before2561_Numberlic.Text = "0";
                son_before2561_Numberlic.Enabled = false;

                son_after2561_Numberlic.Text = "0";
                son_after2561_Numberlic.Enabled = false;
                sum_son = 0;
            }
        }

        private void Have_son_CheckedChanged(object sender, EventArgs e)//เมื่อมีลูก
        {
            if (Have_son.Checked == true)
            {
                son_before2561.Checked = false;
                son_before2561.Enabled = true;

                son_after2561.Checked = false;
                son_after2561.Enabled = true;

                son_before2561_Numberlic.Text = "0";
                son_before2561_Numberlic.Enabled = false;

                son_after2561_Numberlic.Text = "0";
                son_after2561_Numberlic.Enabled = false;
                sum_son = 0;
            }
        }

        private void son_before2561_CheckedChanged(object sender, EventArgs e)
        {
            if (son_before2561.Checked == true)
            {
                son_before2561_Numberlic.Enabled = true;
            }
            else
            {
                son_before2561_Numberlic.Text = "0";
                son_before2561_Numberlic.Enabled = false;
            }
        }

        private void son_after2561_CheckedChanged(object sender, EventArgs e)
        {
            if (son_after2561.Checked == true)
            {
                son_after2561_Numberlic.Enabled = true;
            }
            else
            {
                son_after2561_Numberlic.Text = "0";
                son_after2561_Numberlic.Enabled = false;
            }
        }

        private void father_userTB_CheckedChanged(object sender, EventArgs e) //การตรวจสอบข้อมูล การลดหย่อนพ่อแม่
        {
            if (father_userTB.Checked == true)
            {
                father_User = 1;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
            else
            {
                father_User = 0;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
        }

        private void mother_userTB_CheckedChanged(object sender, EventArgs e)
        {
            if (mother_userTB.Checked == true)
            {
                mother_User = 1;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
            else
            {
                mother_User = 0;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
        }

        private void father_SpouseTB_CheckedChanged(object sender, EventArgs e)
        {
            if (father_SpouseTB.Checked == true)
            {
                father_Spouse = 1;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
            else
            {
                father_Spouse = 0;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
        }

        private void mother_SpouseTB_CheckedChanged(object sender, EventArgs e)
        {
            if (mother_SpouseTB.Checked == true)
            {
                mother_Spouse = 1;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
            else
            {
                mother_Spouse = 0;
                sum_FatherAndMother = 30000 * (father_User + mother_User + father_Spouse + mother_Spouse);
            }
        }

        private void womb_textbox_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(womb_textbox.Text) > 60000)
            {
                womb = 60000;
            }
            else
            {
                womb = Convert.ToDouble(womb_textbox.Text);
            }
        }

        private void cripple_textbox_ValueChanged(object sender, EventArgs e)
        {
            cripple = Convert.ToDouble(cripple_textbox.Text) * 60000;
        }

        private void Back_to_index_Click(object sender, EventArgs e) //เมื่อกดปุ่มกลับในหน้า ตนเองและครอบครัว
        {
            workBar.Location = new Point(0, 268);
            workBar.Size = new Size(8, 60);
            Panelindex.BringToFront();
        }

        private void Next_to_Group2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ลดหย่อนตนเอง  "+ myself +"  บาท"+ "\nลดหย่อนคู่สมรส  " + Spouse.ToString() +"  บาท"+ "\nลดหย่อนค่าบุตร  " + sum_son.ToString() + "  บาท" + "\nลดหย่อนบุพการี  " + sum_FatherAndMother.ToString() + "  บาท" + "\nลดหย่อนการตั้งครรภ์  " + womb.ToString() + "  บาท" + "\nลดหย่อนอุปการะคนพิการ  " + cripple.ToString() + "  บาท", "สรุปการลดหย่อนภาษี กลุ่มตนเอง และครอบครัว");
            workBar.Location = new Point(0, 386);
            workBar.Size = new Size(8, 77);
            Panel_group2.BringToFront();
        }

        private void son_before2561_Numberlic_ValueChanged(object sender, EventArgs e) //เมื่อเกิดการแก้ไขช่องที่ลุก เกิดก่อน 2561
        {
            son_30000 = Convert.ToDouble(son_before2561_Numberlic.Text);
            sum_son = (son_30000 * 30000) + (son_60000 * 60000);
        }

        private void son_after2561_Numberlic_ValueChanged(object sender, EventArgs e) //เมื่อเกิดการแก้ไขช่องที่ลุก เกิดหลัง 2561
        {
            son_60000 = Convert.ToDouble(son_after2561_Numberlic.Text);
            sum_son = (son_30000 * 30000) + (son_60000 * 60000);
        }

        private void index_name_TextChanged(object sender, EventArgs e) //เก็บค่าชื่อผู้ใช้ ในหน้าหลัก
        {
            name = index_name.Text;
        }

        private void index_income_ValueChanged(object sender, EventArgs e)//เก็บค่ารายได้ (income) ในหน้าหลัก
        {
            income = Convert.ToDouble(index_income.Text);
            if (income > 0)
            {
                income = Convert.ToDouble(index_income.Text);
            }
            else
            {
                income = 0;
            }
        }


        //กลุ่มประกัน เงินออมและการลงทุน --------------------------------------------------------------------------------------------------------------------
        private void social_secTB_ValueChanged(object sender, EventArgs e)
        {
            social_security = Convert.ToDouble(social_secTB.Text);
            if (social_security > 9000)
            {
                social_security = 9000;
            }
        }

        private void life_sec_ValueChanged(object sender, EventArgs e)
        {
            life_security = Convert.ToDouble(life_sec.Text);
            if (life_security > 100000)
            {
                life_security = 100000;
            }
            if (life_security + heal_security > 100000)
            {
                MessageBox.Show("เมื่อประกันสุขภาพรวมกับประกันชีวิตแล้วจะต้องไม่เกิน 100,000 บาท");
                life_sec.Text = "0";
                life_security = 0;
            }
        }

        private void heal_sec_ValueChanged(object sender, EventArgs e)
        {
            heal_security = Convert.ToDouble(heal_sec.Text);
            if (heal_security > 15000)
            {
                heal_security = 15000;
            }
            if (life_security + heal_security > 100000)
            {
                MessageBox.Show("เมื่อประกันสุขภาพรวมกับประกันชีวิตแล้วจะต้องไม่เกิน 100,000 บาท");
                heal_sec.Text = "0";
                heal_security = 0;
            }
        }

        private void spouse_sec_ValueChanged(object sender, EventArgs e)
        {
            spouse_security = Convert.ToDouble(spouse_sec.Text);
            if (spouse_security > 10000)
            {
                spouse_security = 10000;
            }
        }

        private void FM_sec_ValueChanged(object sender, EventArgs e)
        {
            FM_security = Convert.ToDouble(FM_sec.Text);
            if (FM_security > 15000)
            {
                FM_security = 15000;
            }
        }

        private void provident_fundTB_ValueChanged(object sender, EventArgs e)
        {
            income = Convert.ToDouble(index_income.Value);
            provident_fund = Convert.ToDouble(provident_fundTB.Text);
            if (provident_fund > 10000)
            {
                //sumgroup();
                if (provident_fund - 10000 < income * 0.15 && provident_fund - 10000 < 490000) //นำส่วนต่างมาคิด
                {
                    income = income - (provident_fund - 10000);
                    provident_fund = 10000;
                }
                else
                {
                    provident_fund = 10000;
                }
            }
            else
            {
                provident_fund = Convert.ToDouble(provident_fundTB.Text);
            }



            if (provident_fund + KOH + teacher_fund + pension + RMF > 500000)
            {
                MessageBox.Show("ซึ่งเมื่อรวมกับกองทุนสำรองเลี้ยงชีพ กบข.กอช.และ RMF จะต้องไม่เกิน 500,000 บาท");
                provident_fund = 0;
                provident_fundTB.Text = "0";
            }
        }

        private void teacher_fundTB_ValueChanged(object sender, EventArgs e)
        {
            teacher_fund = Convert.ToDouble(teacher_fundTB.Text);
            //sumgroup();
            if (teacher_fund <= income * 0.15 && teacher_fund <= 500000) //ถ้าน้อยกว่า 15%
            {
                teacher_fund = Convert.ToDouble(teacher_fundTB.Text);
            }
            else
            {
                teacher_fund = sum_tax * 0.15;
            }

            if (provident_fund + KOH + teacher_fund + pension + RMF > 500000)
            {
                MessageBox.Show("ซึ่งเมื่อรวมกับกองทุนสำรองเลี้ยงชีพ กบข.กอช.และ RMF จะต้องไม่เกิน 500,000 บาท");
                teacher_fund = 0;
                teacher_fundTB.Text = "0";
            }
        }

        private void KOH_TB_ValueChanged(object sender, EventArgs e)
        {
            KOH = Convert.ToDouble(KOH_TB.Text);
            if (KOH > 13200)
            {
                KOH = 13200;
            }

            if (provident_fund + KOH + teacher_fund + pension + RMF > 500000)
            {
                MessageBox.Show("ซึ่งเมื่อรวมกับกองทุนสำรองเลี้ยงชีพ กบข.กอช.และ RMF จะต้องไม่เกิน 500,000 บาท");
                KOH = 0;
                KOH_TB.Text = "0";
            }
        }

        private void pension_TB_ValueChanged(object sender, EventArgs e)
        {
            pension = Convert.ToDouble(pension_TB.Text);
            //sumgroup();
            if (pension <= income * 0.15 && pension <= 200000)
            {
                pension = Convert.ToDouble(pension_TB.Text);
            }
            else
            {
                pension = 200000;
            }


            if (provident_fund + KOH + teacher_fund + pension + RMF > 500000)
            {
                MessageBox.Show("ซึ่งเมื่อรวมกับกองทุนสำรองเลี้ยงชีพ กบข.กอช.และ RMF จะต้องไม่เกิน 500,000 บาท");
                pension = 0;
                pension_TB.Text = "0";
            }
        }

        private void LTF_TB_ValueChanged(object sender, EventArgs e)
        {
            LTF = Convert.ToDouble(LTF_TB.Text);
            if (LTF <= income * 0.15 && LTF <= 500000)
            {
                LTF = Convert.ToDouble(LTF_TB.Text);
            }
            else
            {
                LTF = 500000;
            }
        }

        private void RMF_TB_ValueChanged(object sender, EventArgs e)
        {
            RMF = Convert.ToDouble(RMF_TB.Text);
            //sumgroup();
            if (RMF <= income * 0.15 && RMF <= 500000)
            {
                RMF = Convert.ToDouble(RMF_TB.Text);
            }
            else
            {
                RMF = 500000;
            }
            
            
            
            if (provident_fund + KOH + teacher_fund + pension + RMF > 500000)
            {
                MessageBox.Show("ซึ่งเมื่อรวมกับกองทุนสำรองเลี้ยงชีพ กบข.กอช.และ RMF จะต้องไม่เกิน 500,000 บาท");
                RMF = 0;
                RMF_TB.Text = "0";
            }
        }

        private void back_to_group1_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 327);
            workBar.Size = new Size(8, 60);
            Panel_Group1.BringToFront();
        }

        private void next_to_group3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ประกันสังคม  " + social_security.ToString() + "  บาท"+ "\nประกันชีวิต  " + life_security.ToString() + "  บาท" + "\nประกันสุขภาพ  " + heal_security.ToString() + "  บาท" + "\nประกันคู่สมรส  " + spouse_security.ToString() + "  บาท" + "\nประกันบิดามารดา  " + FM_security.ToString() + "  บาท" + "\nกองทุนสำรองเลี้ยงชีพ  " + provident_fund.ToString() + "  บาท" + "\nกอช.  " + KOH.ToString() + "  บาท" + "\nกองทุนครู  " + teacher_fund.ToString() + "  บาท" + "\nเบี้ยบำนาญ  " + pension.ToString() + "  บาท" + "\nLTF  " + LTF.ToString() + "  บาท" + "\nRMF  " + RMF.ToString() + "  บาท", "สรุปผล");
            workBar.Location = new Point(0, 462);
            workBar.Size = new Size(8, 60);
            Panel_group3.BringToFront();
        }


        //กลุ่มอสังหาริมทรัพย์ --------------------------------------------------------------------------------------------------------------------
        private void buyHome2558_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (buyHome2558_Check.Checked == true)
            {
                buyHome2558.Enabled = true;

                buyHome2562.Enabled = false;
                buyHome2562.Text = "0";
            }
        }

        private void buyHome2562_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (buyHome2562_Check.Checked == true)
            {
                buyHome2562.Enabled = true;

                buyHome2558.Enabled = false;
                buyHome2558.Text = "0";
            }
        }

        private void buyHome2558_ValueChanged(object sender, EventArgs e)
        {
            buyHomefrist_value = Convert.ToDouble(buyHome2558.Text);
            if (buyHomefrist_value > 3000000)
            {
                buyHomefrist_value = 0;
            }
            else
            {

            }
        }

        private void buyHome_TB_ValueChanged(object sender, EventArgs e)
        {
            interestHome_value = Convert.ToDouble(buyHome_TB.Text);
            if (interestHome_value > 100000)
            {
                interestHome_value = 100000;
            }
        }

        private void buyHome2562_ValueChanged(object sender, EventArgs e)
        {
            buyHomefrist_value = Convert.ToDouble(buyHome2562.Text);
            if (buyHomefrist_value > 200000)
            {
                buyHomefrist_value = 200000;
            }
        }

        private void back_to_group2_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 386);
            workBar.Size = new Size(8, 77);
            Panel_group2.BringToFront();
        }

        //กลุ่มเงินบริจาค --------------------------------------------------------------------------------------------------------------------
        private void back_to_group3_Click(object sender, EventArgs e)
        {
            workBar.Location = new Point(0, 462);
            workBar.Size = new Size(8, 60);
            Panel_group3.BringToFront();
        }

        private void next_to_group5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("บริจาคให้สาธารณประโยชน์  " + donate_to_the_state.ToString() + "  บาท" + "\nบริจาคอุทกภัยน้ำท่วมจากพายุปาบึก  " + pabuk.ToString() + "  บาท"+ "\nบริจาคทั่วไป  " + normal_donate.ToString() + "  บาท" + "\nบริจาคให้พรรคการเมือง  " + donate_to_political.ToString() + "  บาท", "สรุปผล");
            workBar.Location = new Point(0, 580);
            workBar.Size = new Size(8, 60);
            Panel_group5.BringToFront();
        }

        private void donate_to_the_state_TB_ValueChanged(object sender, EventArgs e)
        {
            donate_to_the_state = Convert.ToDouble(donate_to_the_state_TB.Text) * 2;
            sumgroup();
            if (donate_to_the_state <= net * 0.15)
            {
                donate_to_the_state = Convert.ToDouble(donate_to_the_state_TB.Text) * 2;
            }
            else
            {
                donate_to_the_state = net * 0.15;
            }
        }

        private void pabuk_TB_ValueChanged(object sender, EventArgs e)
        {
            pabuk = Convert.ToDouble(pabuk_TB.Text);
        }

        private void normal_donate_TB_ValueChanged(object sender, EventArgs e)
        {
            normal_donate = Convert.ToDouble(normal_donate_TB.Text);
            sumgroup();
            if (normal_donate <= net * 0.15)
            {
                normal_donate = Convert.ToDouble(normal_donate_TB.Text);
            }
            else
            {
                normal_donate = net * 0.15;
            }
        }

        private void donate_to_political_TB_ValueChanged(object sender, EventArgs e)
        {
            donate_to_political = Convert.ToDouble(donate_to_political_TB.Text);
            if (donate_to_political > 10000)
            {
                donate_to_political = 10000;
            }
        }

        private void next_to_group4_Click(object sender, EventArgs e) //เมื่อกดปุ่ม ไปหน้าบริจาค
        {
            MessageBox.Show("ดอกเบี้ยบ้าน  " + interestHome_value.ToString() + "  บาท" + "\nโครงการบ้านหลังแรก  " + buyHomefrist_value.ToString() + "  บาท", "สรุปผล");
            workBar.Location = new Point(0, 521);
            workBar.Size = new Size(8, 60);
            Panel_group4.BringToFront();
        }


        //กลุ่มกระตุ้นเศรษฐกิจ --------------------------------------------------------------------------------------------------------------------

        private void shop_help_nation_TB_ValueChanged_1(object sender, EventArgs e)
        {
            shop_help_nation = Convert.ToDouble(shop_help_nation_TB.Text);
            if(shop_help_nation > 15000)
            {
                shop_help_nation = 15000;
            }
        }

        private void shop_sport_TB_ValueChanged(object sender, EventArgs e)
        {
            shop_sport = Convert.ToDouble(shop_sport_TB.Text);
            if (shop_sport > 15000)
            {
                shop_sport = 15000;
            }
        }

        private void shop_book_TB_ValueChanged(object sender, EventArgs e)
        {
            shop_book = Convert.ToDouble(shop_book_TB.Text);
            if (shop_book > 15000)
            {
                shop_book = 15000;
            }
        }

        private void repair_home_frompabuk_TB_ValueChanged(object sender, EventArgs e)
        {
            repair_home_frompabuk = Convert.ToDouble(repair_home_frompabuk_TB.Text);
            if (repair_home_frompabuk > 100000)
            {
                repair_home_frompabuk = 100000;
            }
        }

        private void shop_OTOP_TB_ValueChanged(object sender, EventArgs e)
        {
            shop_OTOP = Convert.ToDouble(shop_OTOP_TB.Text);
            if(shop_OTOP > 15000)
            {
                shop_OTOP = 15000;
            }
        }

        private void repair_home_frompodul_TB_ValueChanged(object sender, EventArgs e)
        {
            repair_home_frompodul = Convert.ToDouble(repair_home_frompodul_TB.Text);
            if (repair_home_frompodul > 100000)
            {
                repair_home_frompodul = 100000;
            }
        }

        private void travel_main_TB_ValueChanged(object sender, EventArgs e)
        {
            travel_main = Convert.ToDouble(travel_main_TB.Text);
            if (travel_main > 15000)
            {
                travel_main = 15000;
            }
            if (travel_main + travel_seconary > 20000)
            {
                MessageBox.Show("เที่ยวเมืองหลักและเที่ยวเมืองรอง จะต้องไม่เกิน 20,000 บาท");
                travel_main_TB.Text = "0";
                travel_main = 0;
            }
        }

        private void travel_seconary_TB_ValueChanged(object sender, EventArgs e)
        {
            travel_seconary = Convert.ToDouble(travel_seconary_TB.Text);
            if (travel_seconary > 20000)
            {
                travel_seconary = 20000;
            }
            if (travel_main + travel_seconary > 20000)
            {
                MessageBox.Show("เที่ยวเมืองหลักและเที่ยวเมืองรอง จะต้องไม่เกิน 20,000 บาท");
                travel_seconary_TB.Text = "0";
                travel_seconary = 0;
            }
        }

        private void repair_car_TB_ValueChanged(object sender, EventArgs e)
        {
            repair_car = Convert.ToDouble(repair_car_TB.Text);
            if (repair_car > 30000)
            {
                repair_car = 30000;
            }
        }

        private void realty_TB_ValueChanged(object sender, EventArgs e)
        {
            realty = Convert.ToDouble(realty_TB.Text);
            if (realty > 30000)
            {
                realty = 30000;
            }
        }

        private void concept_Click(object sender, EventArgs e)
        {
            if (income != Convert.ToDouble(index_income.Text))
            {
                income = Convert.ToDouble(index_income.Text);
            }
            if (name == "")
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้ก่อน");
                workBar.Location = new Point(0, 268);
                workBar.Size = new Size(8, 60);
                Panelindex.BringToFront();
                index_name.Focus();
            }
            else
            {
                workBar.Location = new Point(0, 679);
                workBar.Size = new Size(8, 60);
                Tax_calculation();
                Panel_view.BringToFront();
                income_TB.Text = income.ToString();
                sumtax_TB.Text = sum_tax.ToString();
                net_TB.Text = net.ToString();
                vat_TB.Text = string.Format("{0} %", vat * 100);
                allpay_string_TB.Text = allpay_string;

                Tax_calculation();
                income_TB.Text = income.ToString() + "  บาท";
                sumtax_TB.Text = sum_tax.ToString() + "  บาท";
                net_TB.Text = net.ToString() + "  บาท";
                vat_TB.Text = string.Format("{0} %", vat * 100);
                allpay_string_TB.Text = allpay_string;
            }
            
        }

        private void Tax_calculation()
        {
            try
            {
                //income = Convert.ToDouble(index_income.Value);
                group1 = myself + Spouse + sum_son + sum_FatherAndMother + womb + cripple;
                group2 = social_security + life_security + heal_security + spouse_security + FM_security + provident_fund + KOH + teacher_fund + pension + LTF + RMF;
                group3 = interestHome_value + buyHomefrist_value;
                group4 = donate_to_the_state + pabuk + normal_donate + donate_to_political;
                group5 = shop_help_nation + shop_sport + shop_book + repair_home_frompabuk + repair_home_frompodul + shop_OTOP + travel_main + travel_seconary + repair_car + realty;
                
                sum_tax = group1 + group2 + group3 + group4 + group5;
                net = income - sum_tax;
                //MessageBox.Show(income.ToString(), "");
                if (net < 0)
                {
                    net = 0;
                    allpay = 0;
                    allpay_string = "ไม่ต้องเสียภาษี";
                    vat = 0;
                }
                else if (net <= 150000)
                {
                    allpay = 0;
                    allpay_string = "ไม่ต้องเสียภาษี";
                }
                else if (net > 150000 && net <= 300000)
                {
                    vat = 0.05;
                    allpay = ((net-150000) * vat) + 0;
                    allpay_string = allpay.ToString();
                }
                else if (net > 30000 && net <= 500000)
                {
                    vat = 0.1;
                    allpay = ((net - 300000) * vat) + 7500;
                    allpay_string = allpay.ToString();
                }
                else if (net > 500000 && net <= 750000)
                {
                    vat = 0.15;
                    allpay = ((net - 500000) * vat) + 27500;
                    allpay_string = allpay.ToString();
                }
                else if (net > 750000 && net <= 1000000)
                {
                    vat = 0.2;
                    allpay = ((net - 750000) * vat) + 65000;
                    allpay_string = allpay.ToString();
                }
                else if (net > 1000000 && net <= 2000000)
                {
                    vat = 0.25;
                    allpay = ((net - 1000000) * vat) + 115000;
                    allpay_string = allpay.ToString();
                }
                else if (net > 2000000 && net <= 5000000)
                {
                    vat = 0.30;
                    allpay = ((net - 2000000) * vat) + 365000;
                    allpay_string = allpay.ToString();
                }
                else if (net > 5000000)
                {
                    vat = 0.35;
                    allpay = ((net - 5000000) * vat) + 1265000;
                    allpay_string = allpay.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดขึ้นผิดพลาด กรุณาตรวจสอบข้อมูล" + ex, "การแจ้งเตือน");
            }
        }

        private void next_to_concept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ช้อปช่วยชาติ  " + shop_help_nation.ToString() + "  บาท" + "\nซื้อของกีฬา  " + shop_sport.ToString() + "  บาท" + "\nซื้อหนังสือ  " + shop_book.ToString() + "  บาท" + "\nซ่อมบ้านจากพายุปาบึก  " + repair_home_frompabuk.ToString() + "  บาท" + "\nซ่อมบบ้านจากพายุโพดุล  " + repair_home_frompodul.ToString() + "  บาท" + "\nซื้อสินค้า OTOP  " + shop_OTOP.ToString() + "  บาท" + "\nเที่ยวเมืองหลัก  " + travel_main.ToString() + "  บาท" + "\nเที่ยวเมืองรอง  " + travel_seconary.ToString() + "  บาท" + "\nค่าซ่อมรถ  " + repair_car.ToString() + "  บาท" + "\nอสังหาริมทรัพย์และรถ  " + realty.ToString() + "  บาท", "สรุปผล");
            workBar.Location = new Point(0, 679);
            workBar.Size = new Size(8, 60);
            Tax_calculation();
            Panel_view.BringToFront();
            income_TB.Text = income.ToString();
            sumtax_TB.Text = sum_tax.ToString();
            net_TB.Text = net.ToString();
            vat_TB.Text = string.Format("{0} %", vat * 100);
            allpay_string_TB.Text = allpay_string;

            Tax_calculation();
            income_TB.Text = income.ToString() + "  บาท";
            sumtax_TB.Text = sum_tax.ToString() + "  บาท";
            net_TB.Text = net.ToString() + "  บาท";
            vat_TB.Text = string.Format("{0} %", vat * 100);
            allpay_string_TB.Text = allpay_string;
        }

        private void sumgroup()
        {
            group1 = myself + Spouse + sum_son + sum_FatherAndMother + womb + cripple;
            group2 = social_security + life_security + heal_security + spouse_security + FM_security + provident_fund + KOH + teacher_fund + pension + LTF + RMF;
            group3 = interestHome_value + buyHomefrist_value;
            group4 = donate_to_the_state + pabuk + normal_donate + donate_to_political;
            group5 = shop_help_nation + shop_sport + shop_book + repair_home_frompabuk + repair_home_frompodul + shop_OTOP + travel_main + travel_seconary + repair_car + realty;
            sum_tax = group1 + group2 + group3 + group4 + group5;
            net = income - sum_tax;
        }

        
    }
}
