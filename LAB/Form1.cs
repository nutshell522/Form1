using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB
{
	public partial class Form1 : Form
	{
		// 儲存學生的列表
        private List<Student> _studentList = new List<Student>();
		// 儲存學生的排名
		private Dictionary<int,Student> _gradeRank = new Dictionary<int, Student>();
        public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.Columns.Add("RankList", "名次");
			dataGridView1.Columns.Add("StdIdList", "學生編號");
			dataGridView1.Columns.Add("GradeList", "分數");
			showAverage.Text = "0.00";
		}
		private void submitBtn_Click(object sender, EventArgs e)
		{
			if (_gradeRank.Count >= 5) throw new Exception("列表最多僅儲存五人");
			var student = new Student(stdIdTextBox.Text,new StudentGrade("成績",gradeTextBox.Text));
			_studentList.Add(student);
			_gradeRank = _studentList.ResetRank();
			ShowData();
			ResetAverageScore();
		}
		/// <summary>
		/// 
		/// </summary>
		void ShowData()
		{
			dataGridView1.Rows.Clear();
			foreach (var row in _gradeRank)
			{
				foreach(var grade in row.Value.Grades)
				{
					dataGridView1.Rows.Add(row.Key, row.Value.Id, grade.GradePerSubject);
				}
			}
		}
		void ShowData(string keyWord)
		{
            dataGridView1.Rows.Clear();
            foreach (var row in _gradeRank)
            {
				if (row.Value.Id.Contains(keyWord)){
                    foreach (var grade in row.Value.Grades)
                    {
                        dataGridView1.Rows.Add(row.Key, row.Value.Id, grade.GradePerSubject);
                    }
                }
            }
        }

		private void searchBtn_Click(object sender, EventArgs e)
		{
			ShowData(searchBar.Text);
		}
		/// <summary>
		/// 重設總平均分數
		/// </summary>
		private void ResetAverageScore() {
			showAverage.Text = GradeMathHelper.GetSubjectAverage(_studentList, "成績").ToString("0.00");
		}
	}

	public class Student
	{
		public string Id { get; private set; }
		public List<StudentGrade> Grades { get; private set; }
        public double TotalScore { get; private set; }
        public Student(string stdId, params StudentGrade[] subject)
		{
			if (string.IsNullOrEmpty(stdId)) throw new ArgumentNullException("請輸入ID");
			Id = stdId;
			Grades = subject.ToList();
			SetTotalScore();

		}
		/// <summary>
		/// 設分數總分
		/// </summary>
		private void SetTotalScore()
		{
			double totalScore = 0;
			foreach	(var grade in Grades)
			{
				totalScore += grade.GradePerSubject;
			}
            TotalScore = totalScore;
		}
	}

    public class StudentGrade
    {
        public string SubejectName { get; private set; }
        public double GradePerSubject { get; private set; }
        /// <summary>
        /// 儲存學生科目及成績
        /// </summary>
        /// <param name="subejectName">科目名稱</param>
        /// <param name="subjectGrade">科目成績</param>
        /// <exception cref="ArgumentException"></exception>
        public StudentGrade(string subejectName, string subjectGradeStr)
        {
            double subjectGrade;
            bool result = double.TryParse(subjectGradeStr, out subjectGrade);
            if (!result || subjectGrade < 0 || subjectGrade > 100)
            {
                throw new ArgumentException("請輸入合法成績");
            }

            SubejectName = subejectName;
            GradePerSubject = subjectGrade;
        }
    }

    public static class GradeMathHelper
    {
		/// <summary>
		/// 獲得某科所有人的分數
		/// </summary>
		/// <param name="students">學生名單</param>
		/// <param name="subjectName">科目名稱</param>
		/// <returns></returns>
		public static List<double> GetScoreList(List<Student> students, string subjectName)
		{
			var scoreList = new List<double>();
			foreach(var student in students)
			{
				foreach (StudentGrade grade in student.Grades)
				{
					if (grade.SubejectName == subjectName) scoreList.Add(grade.GradePerSubject);
				}
			}
			return scoreList;
		}
		/// <summary>
		/// 獲得某科所有人分數加總
		/// </summary>
		/// <param name="students">學生名單</param>
		/// <param name="subjectName">科目名稱</param>
		/// <returns></returns>
		public static double GetSubjectSum(List<Student> students,string subjectName)
		{
			return GetScoreList(students, subjectName).Sum(x => x);
		}
		/// <summary>
		/// 獲得某科所有人分數平均
		/// </summary>
		/// <param name="students">學生名單</param>
		/// <param name="subjectName">科目名稱</param>
		/// <returns></returns>
		public static double GetSubjectAverage(List<Student> students,string subjectName)
		{
			return GetSubjectSum(students, subjectName)/(students.Count);
		}
		/// <summary>
		/// 回傳新設的排名值
		/// </summary>
		/// <param name="students">學生清單</param>
		/// <returns></returns>
		public static Dictionary<int, Student> ResetRank(this List<Student> students)
		{
			var map = new Dictionary<int, Student>();
			List<Student> queryOrder = students.OrderByDescending(x => x.TotalScore).ToList();
            for (int i = 0; i < students.Count; i++)
			{
				map.Add(i+1, queryOrder[i]);
			}
			return map;
		}
    }
}
