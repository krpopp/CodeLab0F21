Shader "CodeLab0/MyUnlitShader"
{
    Properties
    {
        // Properties for material inspector, or code
    }
    SubShader
    {
    
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            
            // vertex shader
            float4 vert (float4 vertex : POSITION) : SV_POSITION
            {
                float4 newVert = UnityObjectToClipPos(vertex);        
                return newVert;
            }

            // frag (pixel) shader
            fixed4 frag (float4 vert : POSITION) : SV_Target
            {
                return fixed4(1,1,1,1);
            }
            
            ENDCG
        }
    }
}
