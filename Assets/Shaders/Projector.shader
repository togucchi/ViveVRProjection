﻿// Upgrade NOTE: replaced '_Projector' with 'unity_Projector'
// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/Projector" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		Pass {
			Offset -1, -1
			CGPROGRAM

#pragma vertex vert
#pragma fragment frag
#include "UnityCG.cginc"

sampler2D _MainTex;
float4x4 unity_Projector;

struct v2f {
    float4 pos : SV_POSITION;
    float2 uv : TEXCOORD0;
};

float4 _MainTex_ST;

v2f vert (appdata_base v)
{
    v2f o;
    o.pos = UnityObjectToClipPos (v.vertex);
    float4 p = mul(unity_Projector, v.vertex);
    o.uv = p.xy / p.w;
    return o;
}

half4 frag (v2f i) : COLOR
{
    return tex2D (_MainTex, i.uv);
}

            ENDCG
		}
	} 
	FallBack Off
}