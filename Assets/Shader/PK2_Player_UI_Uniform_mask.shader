Shader "PK2/Player/UI_Uniform_mask" {
	Properties {
		_MinX ("Min X", Float) = -32767
		_MinY ("Min Y", Float) = -32767
		_MaxX ("Max X", Float) = 32767
		_MaxY ("Max Y", Float) = 32767
		_ExcludeMinX ("Min X", Float) = 0
		_ExcludeMaxX ("Max X", Float) = 0
		_ExcludeMinY ("Min Y", Float) = 0
		_ExcludeMaxY ("Max Y", Float) = 0
		[Directional Light] _DirectionalLightColor ("DirLightColor", Vector) = (1,1,1,1)
		_DirectionLightDir ("DirectionLightDir", Vector) = (-0.5,-0.8,-0.3,0)
		[Header(Albedo)] _MainTex ("Albedo(RGB)", 2D) = "white" {}
		_AlbedoIntensity ("Albedo Intensity", Range(0, 10)) = 1
		_Color ("Color", Vector) = (1,1,1,1)
		[Space] [Header(Specular)] [NoScaleOffset] _SpecularMap ("Specualr Map(R:Metallic G:Glossiness B:SSS)", 2D) = "white" {}
		_Metallic ("Metallic", Range(0, 1)) = 0.5
		_Smoothness ("_Smoothness", Range(0, 1)) = 0.5
		_SpecualrColor ("Specualr Color", Vector) = (1,1,1,1)
		[Space] [Header(Normal)] [NoScaleOffset] _NormalMap ("Normal Map", 2D) = "normal" {}
		_BumpScale ("Bump Scale", Range(0, 2)) = 1
		[Space] [Header(Rim)] _RimColor ("Rim Color", Vector) = (1,1,1,1)
		_RimColorPower ("Rim Power", Range(0, 10)) = 10
		_RimColorIntensity ("Rim Intensity", Range(0, 10)) = 0
		[Space] [Header(Light)] _AmbientColor ("Ambient Light Color", Vector) = (0.5,0.5,0.5,0.5)
		_Minimum ("Minimum", Range(0, 1)) = 0
		_ScanLineTex ("ScanLineTex", 2D) = "black" {}
		_ScanLineOffset ("ScanLineOffset", Float) = 0
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
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
			}

			ENDHLSL
		}
	}
	Fallback "SL Legacy Shaders/Diffuse"
}