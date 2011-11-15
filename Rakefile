require 'albacore'

PROJECT = File.dirname(__FILE__).gsub("/", "\\")
ILMERGE = File.join(PROJECT, "util", "ilmerge.exe").gsub("/", "\\")
BUILD   = File.join(PROJECT, "build").gsub("/", "\\")

rm_rf BUILD if File.exist? BUILD
mkdir_p BUILD

desc "Run a sample build using the MSBuildTask"
msbuild :build do |msb|
  msb.properties :configuration => :Release
  msb.targets :Clean, :Build
  msb.solution = "src/InputPanelPlus.sln"
end

task :ilmerge => :build do
  files = ["InputPanelPlus.exe", "mmltex.dll", "Interop.micautLib.dll"]
  files.map! { |f| File.join(PROJECT, "/src/InputPanelPlus/bin/Release/", f).gsub("/", "\\") }
  sh "#{ILMERGE} /target:winexe /out:build/InputPanelPlus.exe " + files.join(" ")
end

task :default => :ilmerge
