using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI 사용시 필요
using UnityEngine.SceneManagement;
using System.Threading;


public class GameDirector1 : MonoBehaviour
{
    //담을 과자들의 가격 정보가 담긴 리스트 선언
    public static List<int> cartList = new List<int>();
    
    //제한시간(30초)
    float setTime = 30;

    //가격 정보가 담긴 리스트
    public int[] price = {3000,500,1500,500,700,500,700,1000,
    700,1000,2000,1000,1200,1300,500,1300,700,
    1500,2000,1500,2000,1500,2000,5000,2000};

    //목표금액 초기화
    public int clearPrice = 0;
    

    GameObject TimeUI;
    GameObject PriceUI;
    GameObject total;
    GameObject whalericeObject;
    GameObject castardObject;
    GameObject homerunball;
    GameObject soursweet1;
    GameObject soursweet2;
    GameObject soursweet3;
    GameObject soursweet4;
    GameObject mychew1;
    GameObject mychew2;
    GameObject mychew3;
    GameObject mychew4;
    GameObject moncher;
    GameObject kancho;
    GameObject backedpotato;

    GameObject cornbackedcorn;
    GameObject cornsavory;
    GameObject cheetos1;
    GameObject cheetos2;
    GameObject wafers1;
    GameObject wafers2;
    GameObject bananasnack;
    GameObject shrimpsnack;
    GameObject honeybutterchip;
    GameObject pockerchip1;
    GameObject pockerchip2;
    GameObject onionring;

    GameObject cashier;


    // Start is called before the first frame update
    void Start()
    {
        //씬 시작될 때 목표 금액과 담긴 과자의 가격 리스트 초기화 시켜주기
        clearPrice = 0;
        cartList = new List<int>();
        

        //게임오브젝트  등록
        this.TimeUI = GameObject.Find("TimeUI");
        this.PriceUI = GameObject.Find("PriceUI");
        this.total = GameObject.Find("total");

        this.whalericeObject = GameObject.Find("whalericeObject");
        this.castardObject = GameObject.Find("castardObject");
        this.homerunball = GameObject.Find("homerunball");
        this.soursweet1 = GameObject.Find("soursweet1");
        this.soursweet2 = GameObject.Find("soursweet2");
        this.soursweet3 = GameObject.Find("soursweet3");
        this.soursweet4 = GameObject.Find("soursweet4");
        this.mychew1 = GameObject.Find("mychew1");
        this.mychew2 = GameObject.Find("mychew2");
        this.mychew3 = GameObject.Find("mychew3");
        this.mychew4 = GameObject.Find("mychew4");
        this.moncher = GameObject.Find("moncher");
        this.kancho = GameObject.Find("kancho");
        this.backedpotato = GameObject.Find("backedpotato");

        this.cornbackedcorn = GameObject.Find("cornbackedcorn");
        this.cornsavory = GameObject.Find("cornsavory");
        this.cheetos1 = GameObject.Find("cheetos1");
        this.cheetos2 = GameObject.Find("cheetos2");
        this.wafers1 = GameObject.Find("wafers1");
        this.wafers2 = GameObject.Find("wafers2");
        this.bananasnack = GameObject.Find("bananasnack");
        this.shrimpsnack = GameObject.Find("shrimpsnack");
        this.honeybutterchip = GameObject.Find("honeybutterchip");
        this.pockerchip1 = GameObject.Find("pockerchip1");
        this.pockerchip2 = GameObject.Find("pockerchip2");
        this.onionring = GameObject.Find("onionring");

        this.cashier = GameObject.Find("cashier");

    
        //중복 없이 랜덤한 숫자 6개 뽑기
        System.Random ran = new System.Random();
        int[] arr = new int[6];      //데이터 6개
        int temp = 0;
        for (int i = 0; i < 6; i++)
        {
            temp = ran.Next(25);
            bool flag = false;
            if (i > 0 && i < 6)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (arr[j] == temp)
                    {
                        flag = true; //중복되면 true로 설정
                    }
                }
            }
           if (flag)
            {
                --i;//중복되었다면 현재 인덱스를 재반복
            }
            else
            {
                arr[i] = temp;//중복된 데이터가 없다면 저장
            }
        }
        for (int i = 0; i < 6; i++)
        {
            int index = arr[i];
            //목표 금액에 랜덤하게 뽑은 숫자 인덱스에 해당하는 가격정보 리스트의 요소들을 더해서 목표 금액이 플레이 할 때마다 랜덤하게 설정됨
            clearPrice += price[index];
            
        }
        //Debug.Log(clearPrice);
        //목표금액 TextUI 설정
        this.PriceUI.GetComponent<Text>().text = "PRICE:"+(int)clearPrice;
        
    }

    //성공시 ClearScene으로 전환
    public void ClearScene(){
        SceneManager.LoadScene("ClearScene");
    }
    //실패시 GameoverScene으로 전환
    public void GameoverScene(){
        SceneManager.LoadScene("GameoverScene");
    }

    public void addCart(int snack_price)
    {
        //담긴 과자 가격 정보 리스트에 가격 담기
        cartList.Add(snack_price);
    }


    void Update()
    {
        // 남은 시간을 감소시켜준다.
        setTime -= Time.deltaTime;
        this.TimeUI.GetComponent<Text>().text = (int)setTime+"";
        
        
        // 남은 시간이 0보다 작아질 때
        if (setTime <= 0)
        {
            //GameoverScene 전환(1.25f만큼 delay 발생)
            Invoke("GameoverScene", 1.25f);
        }
        
        if (Input.GetMouseButtonDown(0))
        {
        	// 마우스 클릭 위치를 카메라 스크린 월드포인트로 변경합니다.
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
 
            // Raycast함수를 통해 부딪치는 collider를 hit에 리턴받습니다.
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
 
            if (hit.collider != null)
            {
                // 어떤 오브젝트인지 로그를 찍습니다.
                //Debug.Log(hit.collider.name);
                //오브젝트 이름에 따라 해당 과자의 가격을 담긴 과자 가격 리스트에 add
                if (hit.collider.name == "whalericeObject"){
                    Destroy(whalericeObject);
                    addCart(700);
                } else if (hit.collider.name == "castardObject") {
                    Destroy(castardObject);
                    addCart(3000);
                } else if (hit.collider.name == "homerunball") {
                    Destroy(homerunball);
                    addCart(2000);
                } else if (hit.collider.name == "soursweet1") {
                    Destroy(soursweet1);
                    addCart(500);
                } else if (hit.collider.name == "soursweet2") {
                    Destroy(soursweet2);
                    addCart(500);
                } else if (hit.collider.name == "soursweet3") {
                    Destroy(soursweet3);
                    addCart(500);
                } else if (hit.collider.name == "soursweet4") {
                    Destroy(soursweet4);
                    addCart(500);
                } else if (hit.collider.name == "moncher") {
                    Destroy(moncher);
                    addCart(5000);
                } else if (hit.collider.name == "backedpotato") {
                    Destroy(backedpotato);
                    addCart(1200);
                } else if (hit.collider.name == "kancho") {
                    Destroy(kancho);
                    addCart(1000);
                } else if (hit.collider.name == "cornbackedcorn") {
                    Destroy(cornbackedcorn);
                    addCart(1500);
                } else if (hit.collider.name == "cornsavory") {
                    Destroy(cornsavory);
                    addCart(1500);
                } else if (hit.collider.name == "cheetos1") {
                    Destroy(cheetos1);
                    addCart(1500);
                } else if (hit.collider.name == "cheetos2") {
                    Destroy(cheetos2);
                    addCart(1500);
                } else if (hit.collider.name == "wafers1") {
                    Destroy(wafers1);
                    addCart(1000);
                } else if (hit.collider.name == "wafers2") {
                    Destroy(wafers2);
                    addCart(1000);
                } else if (hit.collider.name == "bananasnack") {
                    Destroy(bananasnack);
                    addCart(2000);
                } else if (hit.collider.name == "shrimpsnack") {
                    Destroy(shrimpsnack);
                    addCart(2000);
                } else if (hit.collider.name == "honeybutterchip") {
                    Destroy(honeybutterchip);
                    addCart(2000);
                } else if (hit.collider.name == "pockerchip1") {
                    Destroy(pockerchip1);
                    addCart(1300);
                } else if (hit.collider.name == "pockerchip2") {
                    Destroy(pockerchip2);
                    addCart(1300);
                } else if (hit.collider.name == "onionring") {
                    Destroy(onionring);
                    addCart(2000);
                } 
                else if (hit.collider.name == "mychew1") {
                    Destroy(mychew1);
                    addCart(700);
                } else if (hit.collider.name == "mychew2") {
                    Destroy(mychew2);
                    addCart(700);
                } else if (hit.collider.name == "mychew3") {
                    Destroy(mychew3);
                    addCart(700);
                } else if (hit.collider.name == "mychew4") {
                    Destroy(mychew4);
                    addCart(700);
                    
                }
                //만약 카운터 고양이 직원을 탭하면 
                else if (hit.collider.name == "cashier") {
                    int totalValue = 0;
                    for (int i = 0; i < cartList.Count; i++)
                    {
                        
                        totalValue += cartList[i];
                        //Debug.Log(cartList[i]);
                        this.total.GetComponent<Text>().text = totalValue+"";
                        //담긴 과자 가격 리스트들을 다 더해서 계산대 가격 TextUI 설정
                    }
                    //계산대 가격과 목표 금액이 같으면 clearscene으로 전환(1.25f만큼 delay발생)
                    if (totalValue == clearPrice){
                        Debug.Log("SUCCESS!!");
                        Invoke("ClearScene", 1.25f);
                    }
                    //계산대 가격과 목표 금액이 다르면 GameoverScene으로 전환(1.25f만큼 delay발생)
                     else {
                        Debug.Log("Fail...");
                        Invoke("GameoverScene", 1.25f);
                    }
                    
                }
                
            }

        }
        
    }


}
