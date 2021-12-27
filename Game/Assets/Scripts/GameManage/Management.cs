using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Management
{
    // 엔딩 분기점
    public static int A = 0;
    public static int B = 0;
    public static int C = 0;
    public static int D = 0;
    public static int E = 0;
    public static int F = 0;

    // 스테이지
    public static int staff = 0; // 사람으로 스테이지 끝날때마다 +1
    public static int cat = 0; // 고양이로 스테이지 끝날때마다 +1
    // staff = 3, stage1로 돌아가서 고양이로 플레이
    // cat = 3, ending
}
