Shader "MG/Almighty_Additive" {
	Properties {
		_Main_Tex ("Main_Tex", 2D) = "white" {}
		[HDR] _Main_Color ("Main_Color", Vector) = (1,1,1,1)
		_Brightness ("Brightness", Float) = 1
		_Alpha ("Alpha", Float) = 1
		_Main_UV ("Main_UV", Vector) = (0,0,0,0)
		_Tex_2 ("Tex_2", 2D) = "white" {}
		_Tex_2_UV ("Tex_2_UV", Vector) = (0,0,0,0)
		_Turb_Noise ("Turb_Noise", 2D) = "white" {}
		_Turb_Value ("Turb_Value", Float) = 0
		_Turb_UV ("Turb_UV", Vector) = (0,0,0,0)
		_Mask ("Mask", 2D) = "white" {}
		[HideInInspector] _StencilComp ("Stencil Comparison", Float) = 8
		[HideInInspector] _Stencil ("Stencil ID", Float) = 0
		[HideInInspector] _StencilOp ("Stencil Operation", Float) = 0
		[HideInInspector] _StencilWriteMask ("Stencil Write Mask", Float) = 255
		[HideInInspector] _StencilReadMask ("Stencil Read Mask", Float) = 255
		[HideInInspector] _ColorMask ("Color Mask", Float) = 15
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
	//CustomEditor "ASEMaterialInspector"
}