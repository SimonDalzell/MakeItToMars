Shader "Custom/Gradient"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
        _P1 ("Color 1", Color) = (1, 0, 0, 1)
        _P2 ("Color 2", Color) = (0, 0, 1, 1)
    }
    SubShader
{
    Tags { "RenderType"="Opaque" }
    LOD 100

    Pass
    {
        CGPROGRAM
        #pragma vertex vert
        #pragma fragment frag

        #include "UnityCG.cginc"

        struct appdata
        {
            float4 vertex : POSITION;
        };

        struct v2f
        {
            float4 vertex : SV_POSITION;
        };

        fixed4 _P1;
        fixed4 _P2;

        v2f vert (appdata v)
        {
            v2f o;
            o.vertex = UnityObjectToClipPos(v.vertex);
            return o;
        }

        fixed4 frag (v2f i) : SV_Target
        {
            float t = i.vertex.y / _ScreenParams.y;
            return lerp(_P1, _P2, t);
        }
        ENDCG
    }
}
    FallBack "Diffuse"
}
