using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Hotfix
{
    public class MainUI : IUI
    {
        Button m_btn;
        Text m_text;
        float count = 0;
        bool isClick = false;

        public void Start()
        {
            Debug.Log("开始执行热更start函数");
            m_btn = GameObject.Find("Canvas/Button").GetComponent<Button>();
            m_text = GameObject.Find("Canvas/Text").GetComponent<Text>();
            m_text.text = "MainUI Start";

            //点击事件的委托需要在unity中实现委托转换器
            m_btn.onClick.AddListener(BtnClick);
            count = 0;
            
        }
       
        public void Update()
        {
            if (isClick)
            {
                if (count  >=0.1f)
                {
                    m_text.text = "MainUI UpdateMainUI UpdateMainUI Update" + count ;
                    count = 0;
                }
                count += Time.deltaTime;
            }
        }
        void BtnClick()
        {
            isClick = true;
        }
       
    }
}
