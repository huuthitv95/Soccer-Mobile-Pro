Shader "Unlit/HighLight" {
	Properties {
		[HDR] _MainColor ("Main Color", Vector) = (1,1,1,1)
		_MainTex ("Main Tex", 2D) = "white" {}
		_MaskTex ("Mask Tex", 2D) = "white" {}
		[Toggle] _UseCustomData ("UseCustomData", Float) = 0
		[Toggle] _IfRotate ("If Rotate", Float) = 0
		_RotateSpeed ("RotateSpeed", Float) = 1
		[Header(Blend Setting)] [Enum(Off,0,On,1)] _ZWrite ("ZWrite", Float) = 0
		[Enum(UnityEngine.Rendering.CompareFunction)] _ZTest ("ZTest", Float) = 4
		[Enum(UnityEngine.Rendering.BlendMode)] SrcBlend ("SrcBlend", Float) = 5
		[Enum(UnityEngine.Rendering.BlendMode)] DstBlend ("DstBlend", Float) = 10
		[HideInInspector] _Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
		[HideInInspector] _SeparateAlpha ("SeparateAlpha", Float) = 0
		[HideInInspector] _UIFXClipRange0 ("", Vector) = (-100,-100,100,100)
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
}