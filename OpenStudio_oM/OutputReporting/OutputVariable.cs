/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Base;

namespace BH.oM.Adapters.OpenStudio
{
    //public class OutputVariable : BHoMObject
    //{
    //    public string KeyValue { get; set; } = "";
    //    public string VariableName { get; set; } = "";
    //    public OutputVariableReportingFrequencyType ReportingFrequency { get; set; } = OutputVariableReportingFrequencyType.Undefined;
    //    public string ScheduleName { get; set; } = "";
    //}
}

//This is a placeholder for generation of output variables using the oM.EnergyPlus.OutputVariable objects.
//It would be beneficial to set a bunch of default outputs to generate for each simulation (from IDF) to save on storage costs! Otherwise getting everyting would "break the internet"

//Here is the non-exhaustive" list!
//"Air System Component Model Simulation Calls"
//"Air System Simulation Iteration Count"
//"Air System Simulation Maximum Iteration Count"
//"Air System Solver Iteration Count"
//"Debug Surface Solar Shading Model DifShdgRatioHoriz"
//"Debug Surface Solar Shading Model DifShdgRatioIsoSky"
//"Debug Surface Solar Shading Model WithShdgIsoSky"
//"Debug Surface Solar Shading Model WoShdgIsoSky"
//"Electric Equipment Convective Heating Energy"
//"Electric Equipment Convective Heating Rate"
//"Electric Equipment Electric Energy"
//"Electric Equipment Electric Power"
//"Electric Equipment Latent Gain Energy"
//"Electric Equipment Latent Gain Rate"
//"Electric Equipment Lost Heat Energy"
//"Electric Equipment Lost Heat Rate"
//"Electric Equipment Radiant Heating Energy"
//"Electric Equipment Radiant Heating Rate"
//"Electric Equipment Total Heating Energy"
//"Electric Equipment Total Heating Rate"
//"Environmental Impact Total CH4 Emissions Carbon Equivalent Mass"
//"Environmental Impact Total CO2 Emissions Carbon Equivalent Mass"
//"Environmental Impact Total N2O Emissions Carbon Equivalent Mass"
//"Facility Any Zone Oscillating Temperatures Time"
//"Facility Cooling Setpoint Not Met Time"
//"Facility Cooling Setpoint Not Met While Occupied Time"
//"Facility Heating Setpoint Not Met Time"
//"Facility Heating Setpoint Not Met While Occupied Time"
//"Facility Net Purchased Electric Energy"
//"Facility Net Purchased Electric Power"
//"Facility Thermal Comfort ASHRAE 55 Simple Model Summer Clothes Not Comfortable Time"
//"Facility Thermal Comfort ASHRAE 55 Simple Model Summer or Winter Clothes Not Comfortable Time"
//"Facility Thermal Comfort ASHRAE 55 Simple Model Winter Clothes Not Comfortable Time"
//"Facility Total Building Electric Demand Power"
//"Facility Total Electric Demand Power"
//"Facility Total HVAC Electric Demand Power"
//"Facility Total Produced Electric Energy"
//"Facility Total Produced Electric Power"
//"Facility Total Purchased Electric Energy"
//"Facility Total Purchased Electric Power"
//"Facility Total Surplus Electric Energy"
//"Facility Total Surplus Electric Power"
//"HVAC System Solver Iteration Count"
//"Lights Convective Heating Energy"
//"Lights Convective Heating Rate"
//"Lights Electric Energy"
//"Lights Electric Power"
//"Lights Radiant Heating Energy"
//"Lights Radiant Heating Rate"
//"Lights Return Air Heating Energy"
//"Lights Return Air Heating Rate"
//"Lights Total Heating Energy"
//"Lights Total Heating Rate"
//"Lights Visible Radiation Heating Energy"
//"Lights Visible Radiation Heating Rate"
//"People Air Relative Humidity"
//"People Air Temperature"
//"People Convective Heating Energy"
//"People Convective Heating Rate"
//"People Latent Gain Energy"
//"People Latent Gain Rate"
//"People Occupant Count"
//"People Radiant Heating Energy"
//"People Radiant Heating Rate"
//"People Sensible Heating Energy"
//"People Sensible Heating Rate"
//"People Total Heating Energy"
//"People Total Heating Rate"
//"Schedule Value"
//"Site Beam Solar Radiation Luminous Efficacy"
//"Site Day Type Index"
//"Site Daylight Saving Time Status"
//"Site Daylighting Model Sky Brightness"
//"Site Daylighting Model Sky Clearness"
//"Site Deep Ground Temperature"
//"Site Diffuse Solar Radiation Rate per Area"
//"Site Direct Solar Radiation Rate per Area"
//"Site Exterior Beam Normal Illuminance"
//"Site Exterior Horizontal Beam Illuminance"
//"Site Exterior Horizontal Sky Illuminance"
//"Site Ground Reflected Solar Radiation Rate per Area"
//"Site Ground Temperature"
//"Site Horizontal Infrared Radiation Rate per Area"
//"Site Mains Water Temperature"
//"Site Outdoor Air Barometric Pressure"
//"Site Outdoor Air Density"
//"Site Outdoor Air Dewpoint Temperature"
//"Site Outdoor Air Drybulb Temperature"
//"Site Outdoor Air Enthalpy"
//"Site Outdoor Air Humidity Ratio"
//"Site Outdoor Air Relative Humidity"
//"Site Outdoor Air Wetbulb Temperature"
//"Site Precipitation Depth"
//"Site Rain Status"
//"Site Simple Factor Model Ground Temperature"
//"Site Sky Diffuse Solar Radiation Luminous Efficacy"
//"Site Sky Temperature"
//"Site Snow on Ground Status"
//"Site Solar Altitude Angle"
//"Site Solar Azimuth Angle"
//"Site Solar Hour Angle"
//"Site Surface Ground Temperature"
//"Site Wind Direction"
//"Site Wind Speed"
//"Surface Anisotropic Sky Multiplier"
//"Surface Average Face Conduction Heat Gain Rate"
//"Surface Average Face Conduction Heat Loss Rate"
//"Surface Average Face Conduction Heat Transfer Energy"
//"Surface Average Face Conduction Heat Transfer Rate"
//"Surface Average Face Conduction Heat Transfer Rate per Area"
//"Surface Heat Storage Energy"
//"Surface Heat Storage Gain Rate"
//"Surface Heat Storage Loss Rate"
//"Surface Heat Storage Rate"
//"Surface Heat Storage Rate per Area"
//"Surface Inside Face Absorbed Shortwave Radiation Rate"
//"Surface Inside Face Adjacent Air Temperature"
//"Surface Inside Face Beam Solar Radiation Heat Gain Rate"
//"Surface Inside Face Conduction Heat Gain Rate"
//"Surface Inside Face Conduction Heat Loss Rate"
//"Surface Inside Face Conduction Heat Transfer Energy"
//"Surface Inside Face Conduction Heat Transfer Rate"
//"Surface Inside Face Conduction Heat Transfer Rate per Area"
//"Surface Inside Face Convection Classification Index"
//"Surface Inside Face Convection Heat Gain Energy"
//"Surface Inside Face Convection Heat Gain Rate"
//"Surface Inside Face Convection Heat Gain Rate per Area"
//"Surface Inside Face Convection Heat Transfer Coefficient"
//"Surface Inside Face Convection Model Equation Index"
//"Surface Inside Face Convection Reference Air Index"
//"Surface Inside Face Exterior Windows Incident Beam Solar Radiation Energy"
//"Surface Inside Face Exterior Windows Incident Beam Solar Radiation Rate"
//"Surface Inside Face Exterior Windows Incident Beam Solar Radiation Rate per Area"
//"Surface Inside Face Initial Transmitted Diffuse Absorbed Solar Radiation Rate"
//"Surface Inside Face Initial Transmitted Diffuse Transmitted Out Window Solar Radiation Rate"
//"Surface Inside Face Interior Windows Incident Beam Solar Radiation Energy"
//"Surface Inside Face Interior Windows Incident Beam Solar Radiation Rate"
//"Surface Inside Face Interior Windows Incident Beam Solar Radiation Rate per Area"
//"Surface Inside Face Internal Gains Radiation Heat Gain Energy"
//"Surface Inside Face Internal Gains Radiation Heat Gain Rate"
//"Surface Inside Face Internal Gains Radiation Heat Gain Rate per Area"
//"Surface Inside Face Lights Radiation Heat Gain Energy"
//"Surface Inside Face Lights Radiation Heat Gain Rate"
//"Surface Inside Face Lights Radiation Heat Gain Rate per Area"
//"Surface Inside Face Net Surface Thermal Radiation Heat Gain Energy"
//"Surface Inside Face Net Surface Thermal Radiation Heat Gain Rate"
//"Surface Inside Face Net Surface Thermal Radiation Heat Gain Rate per Area"
//"Surface Inside Face Solar Radiation Heat Gain Energy"
//"Surface Inside Face Solar Radiation Heat Gain Rate"
//"Surface Inside Face Solar Radiation Heat Gain Rate per Area"
//"Surface Inside Face System Radiation Heat Gain Energy"
//"Surface Inside Face System Radiation Heat Gain Rate"
//"Surface Inside Face System Radiation Heat Gain Rate per Area"
//"Surface Inside Face Temperature"
//"Surface Outside Face Beam Solar Incident Angle Cosine Value"
//"Surface Outside Face Conduction Heat Gain Rate"
//"Surface Outside Face Conduction Heat Loss Rate"
//"Surface Outside Face Conduction Heat Transfer Energy"
//"Surface Outside Face Conduction Heat Transfer Rate"
//"Surface Outside Face Conduction Heat Transfer Rate per Area"
//"Surface Outside Face Convection Classification Index"
//"Surface Outside Face Convection Heat Gain Energy"
//"Surface Outside Face Convection Heat Gain Rate"
//"Surface Outside Face Convection Heat Gain Rate per Area"
//"Surface Outside Face Convection Heat Transfer Coefficient"
//"Surface Outside Face Forced Convection Model Equation Index"
//"Surface Outside Face Incident Beam Solar Radiation Rate per Area"
//"Surface Outside Face Incident Beam To Beam Surface Reflected Solar Radiation Rate per Area"
//"Surface Outside Face Incident Beam To Diffuse Ground Reflected Solar Radiation Rate per Area"
//"Surface Outside Face Incident Beam To Diffuse Surface Reflected Solar Radiation Rate per Area"
//"Surface Outside Face Incident Ground Diffuse Solar Radiation Rate per Area"
//"Surface Outside Face Incident Sky Diffuse Ground Reflected Solar Radiation Rate per Area"
//"Surface Outside Face Incident Sky Diffuse Solar Radiation Rate per Area"
//"Surface Outside Face Incident Sky Diffuse Surface Reflected Solar Radiation Rate per Area"
//"Surface Outside Face Incident Solar Radiation Rate per Area"
//"Surface Outside Face Natural Convection Model Equation Index"
//"Surface Outside Face Net Thermal Radiation Heat Gain Energy"
//"Surface Outside Face Net Thermal Radiation Heat Gain Rate"
//"Surface Outside Face Net Thermal Radiation Heat Gain Rate per Area"
//"Surface Outside Face Outdoor Air Drybulb Temperature"
//"Surface Outside Face Outdoor Air Wetbulb Temperature"
//"Surface Outside Face Outdoor Air Wind Direction"
//"Surface Outside Face Outdoor Air Wind Speed"
//"Surface Outside Face Solar Radiation Heat Gain Energy"
//"Surface Outside Face Solar Radiation Heat Gain Rate"
//"Surface Outside Face Solar Radiation Heat Gain Rate per Area"
//"Surface Outside Face Sunlit Area"
//"Surface Outside Face Sunlit Fraction"
//"Surface Outside Face Temperature"
//"Surface Outside Face Thermal Radiation to Air Heat Transfer Coefficient"
//"Surface Outside Face Thermal Radiation to Ground Heat Transfer Coefficient"
//"Surface Outside Face Thermal Radiation to Sky Heat Transfer Coefficient"
//"Surface Outside Normal Azimuth Angle"
//"Surface Window BSDF Beam Direction Number"
//"Surface Window BSDF Beam Phi Angle"
//"Surface Window BSDF Beam Theta Angle"
//"System Node Current Density"
//"System Node Current Density Volume Flow Rate"
//"System Node Dewpoint Temperature"
//"System Node Enthalpy"
//"System Node Height"
//"System Node Humidity Ratio"
//"System Node Mass Flow Rate"
//"System Node Pressure"
//"System Node Quality"
//"System Node Relative Humidity"
//"System Node Setpoint High Temperature"
//"System Node Setpoint Humidity Ratio"
//"System Node Setpoint Low Temperature"
//"System Node Setpoint Maximum Humidity Ratio"
//"System Node Setpoint Minimum Humidity Ratio"
//"System Node Setpoint Temperature"
//"System Node Specific Heat"
//"System Node Standard Density Volume Flow Rate"
//"System Node Temperature"
//"System Node Wetbulb Temperature"
//"System Node Wind Direction"
//"System Node Wind Speed"
//"Zone Adaptive Comfort Operative Temperature Set Point"
//"Zone Air Heat Balance Air Energy Storage Rate"
//"Zone Air Heat Balance Internal Convective Heat Gain Rate"
//"Zone Air Heat Balance Interzone Air Transfer Rate"
//"Zone Air Heat Balance Outdoor Air Transfer Rate"
//"Zone Air Heat Balance Surface Convection Rate"
//"Zone Air Heat Balance System Air Transfer Rate"
//"Zone Air Heat Balance System Convective Heat Gain Rate"
//"Zone Air Humidity Ratio"
//"Zone Air Relative Humidity"
//"Zone Air System Sensible Cooling Energy"
//"Zone Air System Sensible Cooling Rate"
//"Zone Air System Sensible Heating Energy"
//"Zone Air System Sensible Heating Rate"
//"Zone Air Temperature"
//"Zone Cooling Setpoint Not Met Time"
//"Zone Cooling Setpoint Not Met While Occupied Time"
//"Zone Electric Equipment Convective Heating Energy"
//"Zone Electric Equipment Convective Heating Rate"
//"Zone Electric Equipment Electric Energy"
//"Zone Electric Equipment Electric Power"
//"Zone Electric Equipment Latent Gain Energy"
//"Zone Electric Equipment Latent Gain Rate"
//"Zone Electric Equipment Lost Heat Energy"
//"Zone Electric Equipment Lost Heat Rate"
//"Zone Electric Equipment Radiant Heating Energy"
//"Zone Electric Equipment Radiant Heating Rate"
//"Zone Electric Equipment Total Heating Energy"
//"Zone Electric Equipment Total Heating Rate"
//"Zone Exterior Windows Total Transmitted Beam Solar Radiation Energy"
//"Zone Exterior Windows Total Transmitted Beam Solar Radiation Rate"
//"Zone Exterior Windows Total Transmitted Diffuse Solar Radiation Energy"
//"Zone Exterior Windows Total Transmitted Diffuse Solar Radiation Rate"
//"Zone Heating Setpoint Not Met Time"
//"Zone Heating Setpoint Not Met While Occupied Time"
//"Zone Ideal Loads Economizer Active Time"
//"Zone Ideal Loads Heat Recovery Active Time"
//"Zone Ideal Loads Heat Recovery Latent Cooling Energy"
//"Zone Ideal Loads Heat Recovery Latent Cooling Rate"
//"Zone Ideal Loads Heat Recovery Latent Heating Energy"
//"Zone Ideal Loads Heat Recovery Latent Heating Rate"
//"Zone Ideal Loads Heat Recovery Sensible Cooling Energy"
//"Zone Ideal Loads Heat Recovery Sensible Cooling Rate"
//"Zone Ideal Loads Heat Recovery Sensible Heating Energy"
//"Zone Ideal Loads Heat Recovery Sensible Heating Rate"
//"Zone Ideal Loads Heat Recovery Total Cooling Energy"
//"Zone Ideal Loads Heat Recovery Total Cooling Rate"
//"Zone Ideal Loads Heat Recovery Total Heating Energy"
//"Zone Ideal Loads Heat Recovery Total Heating Rate"
//"Zone Ideal Loads Hybrid Ventilation Available Status"
//"Zone Ideal Loads Outdoor Air Latent Cooling Energy"
//"Zone Ideal Loads Outdoor Air Latent Cooling Rate"
//"Zone Ideal Loads Outdoor Air Latent Heating Energy"
//"Zone Ideal Loads Outdoor Air Latent Heating Rate"
//"Zone Ideal Loads Outdoor Air Mass Flow Rate"
//"Zone Ideal Loads Outdoor Air Sensible Cooling Energy"
//"Zone Ideal Loads Outdoor Air Sensible Cooling Rate"
//"Zone Ideal Loads Outdoor Air Sensible Heating Energy"
//"Zone Ideal Loads Outdoor Air Sensible Heating Rate"
//"Zone Ideal Loads Outdoor Air Standard Density Volume Flow Rate"
//"Zone Ideal Loads Outdoor Air Total Cooling Energy"
//"Zone Ideal Loads Outdoor Air Total Cooling Rate"
//"Zone Ideal Loads Outdoor Air Total Heating Energy"
//"Zone Ideal Loads Outdoor Air Total Heating Rate"
//"Zone Ideal Loads Supply Air Latent Cooling Energy"
//"Zone Ideal Loads Supply Air Latent Cooling Rate"
//"Zone Ideal Loads Supply Air Latent Heating Energy"
//"Zone Ideal Loads Supply Air Latent Heating Rate"
//"Zone Ideal Loads Supply Air Mass Flow Rate"
//"Zone Ideal Loads Supply Air Sensible Cooling Energy"
//"Zone Ideal Loads Supply Air Sensible Cooling Rate"
//"Zone Ideal Loads Supply Air Sensible Heating Energy"
//"Zone Ideal Loads Supply Air Sensible Heating Rate"
//"Zone Ideal Loads Supply Air Standard Density Volume Flow Rate"
//"Zone Ideal Loads Supply Air Total Cooling Energy"
//"Zone Ideal Loads Supply Air Total Cooling Rate"
//"Zone Ideal Loads Supply Air Total Heating Energy"
//"Zone Ideal Loads Supply Air Total Heating Rate"
//"Zone Ideal Loads Zone Latent Cooling Energy"
//"Zone Ideal Loads Zone Latent Cooling Rate"
//"Zone Ideal Loads Zone Latent Heating Energy"
//"Zone Ideal Loads Zone Latent Heating Rate"
//"Zone Ideal Loads Zone Sensible Cooling Energy"
//"Zone Ideal Loads Zone Sensible Cooling Rate"
//"Zone Ideal Loads Zone Sensible Heating Energy"
//"Zone Ideal Loads Zone Sensible Heating Rate"
//"Zone Ideal Loads Zone Total Cooling Energy"
//"Zone Ideal Loads Zone Total Cooling Rate"
//"Zone Ideal Loads Zone Total Heating Energy"
//"Zone Ideal Loads Zone Total Heating Rate"
//"Zone Infiltration Air Change Rate"
//"Zone Infiltration Current Density Volume"
//"Zone Infiltration Current Density Volume Flow Rate"
//"Zone Infiltration Latent Heat Gain Energy"
//"Zone Infiltration Latent Heat Loss Energy"
//"Zone Infiltration Mass"
//"Zone Infiltration Mass Flow Rate"
//"Zone Infiltration Sensible Heat Gain Energy"
//"Zone Infiltration Sensible Heat Loss Energy"
//"Zone Infiltration Standard Density Volume"
//"Zone Infiltration Standard Density Volume Flow Rate"
//"Zone Infiltration Total Heat Gain Energy"
//"Zone Infiltration Total Heat Loss Energy"
//"Zone Interior Windows Total Transmitted Beam Solar Radiation Energy"
//"Zone Interior Windows Total Transmitted Beam Solar Radiation Rate"
//"Zone Interior Windows Total Transmitted Diffuse Solar Radiation Energy"
//"Zone Interior Windows Total Transmitted Diffuse Solar Radiation Rate"
//"Zone Lights Convective Heating Energy"
//"Zone Lights Convective Heating Rate"
//"Zone Lights Electric Energy"
//"Zone Lights Electric Power"
//"Zone Lights Radiant Heating Energy"
//"Zone Lights Radiant Heating Rate"
//"Zone Lights Return Air Heating Energy"
//"Zone Lights Return Air Heating Rate"
//"Zone Lights Total Heating Energy"
//"Zone Lights Total Heating Rate"
//"Zone Lights Visible Radiation Heating Energy"
//"Zone Lights Visible Radiation Heating Rate"
//"Zone List Sensible Cooling Energy"
//"Zone List Sensible Cooling Rate"
//"Zone List Sensible Heating Energy"
//"Zone List Sensible Heating Rate"
//"Zone Mean Air Dewpoint Temperature"
//"Zone Mean Air Humidity Ratio"
//"Zone Mean Air Temperature"
//"Zone Mean Radiant Temperature"
//"Zone Mechanical Ventilation Air Changes per Hour"
//"Zone Mechanical Ventilation Cooling Load Decrease Energy"
//"Zone Mechanical Ventilation Cooling Load Increase Due to Overheating Energy"
//"Zone Mechanical Ventilation Cooling Load Increase Energy"
//"Zone Mechanical Ventilation Current Density Volume"
//"Zone Mechanical Ventilation Current Density Volume Flow Rate"
//"Zone Mechanical Ventilation Heating Load Decrease Energy"
//"Zone Mechanical Ventilation Heating Load Increase Due to Overcooling Energy"
//"Zone Mechanical Ventilation Heating Load Increase Energy"
//"Zone Mechanical Ventilation Mass"
//"Zone Mechanical Ventilation Mass Flow Rate"
//"Zone Mechanical Ventilation No Load Heat Addition Energy"
//"Zone Mechanical Ventilation No Load Heat Removal Energy"
//"Zone Mechanical Ventilation Standard Density Volume"
//"Zone Mechanical Ventilation Standard Density Volume Flow Rate"
//"Zone Operative Temperature"
//"Zone Oscillating Temperatures Time"
//"Zone Outdoor Air Drybulb Temperature"
//"Zone Outdoor Air Wetbulb Temperature"
//"Zone Outdoor Air Wind Direction"
//"Zone Outdoor Air Wind Speed"
//"Zone People Convective Heating Energy"
//"Zone People Convective Heating Rate"
//"Zone People Latent Gain Energy"
//"Zone People Latent Gain Rate"
//"Zone People Occupant Count"
//"Zone People Radiant Heating Energy"
//"Zone People Radiant Heating Rate"
//"Zone People Sensible Heating Energy"
//"Zone People Sensible Heating Rate"
//"Zone People Total Heating Energy"
//"Zone People Total Heating Rate"
//"Zone Predicted Moisture Load Moisture Transfer Rate"
//"Zone Predicted Moisture Load to Dehumidifying Setpoint Moisture Transfer Rate"
//"Zone Predicted Moisture Load to Humidifying Setpoint Moisture Transfer Rate"
//"Zone Predicted Sensible Load Room Air Correction Factor"
//"Zone Predicted Sensible Load to Cooling Setpoint Heat Transfer Rate"
//"Zone Predicted Sensible Load to Heating Setpoint Heat Transfer Rate"
//"Zone Predicted Sensible Load to Setpoint Heat Transfer Rate"
//"Zone Thermal Comfort ASHRAE 55 Simple Model Summer Clothes Not Comfortable Time"
//"Zone Thermal Comfort ASHRAE 55 Simple Model Summer or Winter Clothes Not Comfortable Time"
//"Zone Thermal Comfort ASHRAE 55 Simple Model Winter Clothes Not Comfortable Time"
//"Zone Thermostat Air Temperature"
//"Zone Thermostat Control Type"
//"Zone Thermostat Cooling Setpoint Temperature"
//"Zone Thermostat Heating Setpoint Temperature"
//"Zone Total Internal Convective Heating Energy"
//"Zone Total Internal Convective Heating Rate"
//"Zone Total Internal Latent Gain Energy"
//"Zone Total Internal Latent Gain Rate"
//"Zone Total Internal Radiant Heating Energy"
//"Zone Total Internal Radiant Heating Rate"
//"Zone Total Internal Total Heating Energy"
//"Zone Total Internal Total Heating Rate"
//"Zone Total Internal Visible Radiation Heating Energy"
//"Zone Total Internal Visible Radiation Heating Rate"
//"Zone Ventilation Air Change Rate"
//"Zone Ventilation Air Inlet Temperature"
//"Zone Ventilation Current Density Volume"
//"Zone Ventilation Current Density Volume Flow Rate"
//"Zone Ventilation Fan Electric Energy"
//"Zone Ventilation Latent Heat Gain Energy"
//"Zone Ventilation Latent Heat Loss Energy"
//"Zone Ventilation Mass"
//"Zone Ventilation Mass Flow Rate"
//"Zone Ventilation Sensible Heat Gain Energy"
//"Zone Ventilation Sensible Heat Loss Energy"
//"Zone Ventilation Standard Density Volume"
//"Zone Ventilation Standard Density Volume Flow Rate"
//"Zone Ventilation Total Heat Gain Energy"
//"Zone Ventilation Total Heat Loss Energy"
//"Zone Windows Total Heat Gain Energy"
//"Zone Windows Total Heat Gain Rate"
//"Zone Windows Total Heat Loss Energy"
//"Zone Windows Total Heat Loss Rate"
//"Zone Windows Total Transmitted Solar Radiation Energy"
//"Zone Windows Total Transmitted Solar Radiation Rate"



