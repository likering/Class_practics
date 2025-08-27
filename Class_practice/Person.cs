using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice
{
    internal class Person
    {
        //変数
        protected string name;//キャラの名前
        protected int level;//レベル
        protected int hp;//体力
        protected string info = "ただの村人";//キャラの属性の特徴


        //List 所持アイテム
        public List<string> items= new List<string>();

        //実体化した際に基本的な情報は入るように設計
        //引数なしコンストラクタ
        public Person()
        {

            name = "イッパンジーン";
            level = 1;
            hp = 100;

        }
        //引数ありコンストラクタ
        public Person(string n, int h)
        {
            name = n;
            level = 1;
            hp = h;
        }

        //命令（メソッド）
        //そのキャラの情報を表示するメソッド
        //継承先えオーバーライド
        public virtual void InfoDisplay()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("名前:" + name);
            Console.WriteLine("レベル" + level);
            Console.WriteLine("体力" + hp);
            Console.WriteLine(info);


        }
        //メンバー変数に干渉する為のメソッド達
        //名前を変更するメソッド
        public void NameSet(string value)
        {
            name = value;


        }
        //hpを変更するメソッド
        public void HPSet(int value)
        {
            hp = value;
        }
        //メンバー変数に干渉する為のプロパティ
        //nameという言い方ならnameに干渉できるように設計
        public string Name
        {
            get { return name; }//読み取り機能　本来不干渉のnameの値をリターン（ゲット）します
            //set { name = value; }//書き込み機能　本来不干渉のnameの値に「nameに代入された値」を代入
        }
        //技をひとつ公表するメソッド
        //オーバーライドして引数あり、なし、二種類作っておく
        
            //継承先でオーバーライドされるメソッドの予定なのでvirtual宣言も加えておく
            public virtual void AttackInfo(int x)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine("技:必殺の右ストレート");
                    break;
                default:
                    Console.WriteLine("技:渾身のタックル");
                    break;

            }


        }
        public virtual void AttackInfo()
        {
            Console.WriteLine("技:渾身のタックル");

        }

    }
}
