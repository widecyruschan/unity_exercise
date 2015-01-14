public static void ShowObj(GameObject obj,bool show)
    {
        unityEngine.Renderer[] allObj = obj.GetComponentsInChildren<UnityEngine.Renderer>();
        foreach (Renderer a in allObj)
        {
            a.renderer.enabled = show;
        }
//两种方法
        for (int i = 0; i < allObj.Length; i++)
        {
            allObj.renderer.enabled = show;
        }
    }